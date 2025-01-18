using System.Text;

namespace AssemblyImporter;

public static class GeneratedTypeFormatter {
    public static string Format(IGeneratedType t) => $"{t.Name}";

    public static string Format(IGeneratedTypeDeclaration root) {
        StringBuilder sb = new();

        List<string> namespaces = [];
        GatherUsedNamespaces(root, namespaces);

        if (namespaces.Count > 0) {
            foreach (string ns in namespaces.Distinct().Order()) {
                sb.AppendLine($"using {ns};");
            }

            sb.AppendLine();
        }

        bool hasNamespace = !string.IsNullOrWhiteSpace(root.Namespace);

        if (hasNamespace) {
            sb.AppendLine($"namespace {root.Namespace} {{");
            sb.AppendLine();
        }

        sb.AppendLine(FormatTypeDecl(root));

        if (hasNamespace) {
            sb.AppendLine("}");
            sb.AppendLine();
        }

        return sb.ToString();
    }

    private static string FormatTypeDecl(IGeneratedTypeDeclaration t, int indent = 0) {
        StringBuilder sb = new();

        string keyword = t switch {
            GeneratedTypeClassDeclaration => "class",
            GeneratedTypeEnumDeclaration => "enum",
            GeneratedTypeInterfaceDeclaration => "interface",
            GeneratedTypeStructDeclaration => "struct",
            _ => throw new($"Unsupported type: {t}")
        };

        sb.Append(WithIndent($"public {keyword} {t.Name} ", indent));

        IEnumerable<IGeneratedType> baseTypesToInclude = t.BaseTypes.Where(ShouldIncludeBaseType);

        if (baseTypesToInclude.Any()) {
            sb.Append($": {string.Join(", ", baseTypesToInclude.Select(FormatTypeName))} ");
        }

        sb.AppendLine("{");

        foreach (IGeneratedField f in t.Fields) {
            sb.AppendLine(WithIndent($"{FormatField(f)};", indent + 1));
        }

        if (t is GeneratedTypeEnumDeclaration et) {
            for (int i = 0; i < et.Names.Count; ++i) {
                sb.AppendLine(WithIndent($"{et.Names[i]} = {et.Values[i]},", indent + 1));
            }
        }

        if (t.NestedTypes.Count > 0) {
            sb.AppendLine();

            foreach (IGeneratedTypeDeclaration nt in t.NestedTypes) {
                sb.AppendLine(FormatTypeDecl(nt, indent + 1));
            }
        }

        sb.AppendLine(WithIndent("}", indent));

        return sb.ToString();
    }

    private static string FormatField(IGeneratedField f) {
        StringBuilder sb = new();

        if (f.Attributes.Any(x => x.Name == "SerializeField")) {
            sb.Append("[SerializeField] ");
        }

        if (f is GeneratedArrayField af) {
            string arity = string.Join("", Enumerable.Repeat("[]", af.Arity));
            sb.Append($"public {FormatTypeName(af.ArrayType)}{arity} {af.Name}");
            sb.Append($" /* {af.ArrayType.Namespace}.{af.ArrayType.Name}{arity} */");
        } else if (f is GeneratedGenericField gf) {
            sb.Append($"public {FormatTypeName(gf.Type)}<{string.Join(", ", gf.GenericTypes.Select(FormatTypeName))}> {gf.Name}");
            sb.Append($" /* {gf.Type.Namespace}.{gf.Type.Name}<{string.Join(", ", gf.GenericTypes.Select(x => $"{x.Namespace}.{x.Name}"))}> */");
        } else {
            sb.Append($"public {FormatTypeName(f.Type)} {f.Name}");
            sb.Append($" /* {f.Type.Namespace}.{f.Type.Name} */");
        }

        return sb.ToString();
    }

    private static string FormatTypeName(IGeneratedType type) => type switch {
        GeneratedTypeForwardDecl => "object",
        { Namespace: "UnityEngine", Name: "Object" } => "UnityEngine.Object",
        { Namespace: "System", Name: "Byte" } => "byte",
        { Namespace: "System", Name: "Int16" } => "short",
        { Namespace: "System", Name: "Int32" } => "int",
        { Namespace: "System", Name: "Int64" } => "long",
        { Namespace: "System", Name: "UInt16" } => "ushort",
        { Namespace: "System", Name: "UInt32" } => "uint",
        { Namespace: "System", Name: "UInt64" } => "ulong",
        { Namespace: "System", Name: "Single" } => "float",
        { Namespace: "System", Name: "Double" } => "double",
        { Namespace: "System", Name: "Boolean" } => "bool",
        { Namespace: "System", Name: "String" } => "string",
        { Namespace: "System", Name: "Object" } => "object",
        _ => ResolveNestedTypeName(type)
    };

    private static string ResolveNestedTypeName(IGeneratedType type) {
        List<Type> nestedTypes = [];

        Type? refType = type.ReferencedType.DeclaringType;
        while (refType != null) {
            nestedTypes.Add(refType);
            refType = refType.DeclaringType;
        }

        List<string> typeNames = [type.Name];
        
        if (type.Namespace.Split('.').Last() == type.Name) {
            typeNames.Add(type.Namespace);
        }

        typeNames.AddRange(nestedTypes.Select(x => x.Name));
        typeNames.Reverse();

        return string.Join('.', typeNames);
    }

    private static bool ShouldIncludeBaseType(IGeneratedType t) => t is not (
        GeneratedTypeForwardDecl or
        GeneratedTypeInterfaceDeclaration or
        { Name: "Array" or "Delegate" or "Enum" or "Object" or "ValueType", Namespace: "System" }
    );

    private static void GatherUsedNamespaces(IGeneratedTypeDeclaration gen, List<string> namespaces) {
        List<IGeneratedType> referencedTypes = [];
        TypeGeneratorUtil.CollectListOfReferencedTypes(gen, referencedTypes);

        namespaces.AddRange(referencedTypes
            .Where(x => 
                !string.IsNullOrWhiteSpace(x.Namespace) &&
                x.Namespace != gen.Namespace &&
                x is not (
                    GeneratedTypeForwardDecl or
                    GeneratedTypeInterfaceDeclaration))
            .Select(x => x.Namespace));
    }

    private static string WithIndent(string s, int indent) => $"{new string(' ', indent * 4)}{s}";
}