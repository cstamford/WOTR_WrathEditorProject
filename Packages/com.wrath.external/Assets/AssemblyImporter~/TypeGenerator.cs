using System.Reflection;
using System.Runtime.CompilerServices;

using static AssemblyImporter.TypeGeneratorUtil;

namespace AssemblyImporter;

public interface IGeneratedType {
    public string Name { get; }
    public string Namespace { get; }
    public Type ReferencedType { get; }
}

public interface IGeneratedTypeDeclaration : IGeneratedType {
    public List<IGeneratedType> BaseTypes { get; }
    public List<IGeneratedField> Fields { get; }
    public List<IGeneratedTypeDeclaration> NestedTypes { get; }
}

public interface IGeneratedField {
    public FieldInfo ReferencedField { get; }
    public string Name { get; }
    public IGeneratedType Type { get; }
    public List<IGeneratedType> Attributes { get; }
}

public abstract record class GeneratedTypeBase(string Name, string Namespace) {
    public GeneratedTypeBase(Type type) : this(type.Name.Split('`')[0], type.Namespace ?? string.Empty) { }
    public static IGeneratedType Create(Dictionary<Type, IGeneratedType> lookup, Type type) => CreateGeneratedType(lookup, type);
}

public record class GeneratedType(Type ReferencedType) : GeneratedTypeBase(ReferencedType), IGeneratedType;
public record class GeneratedTypeForwardDecl(Type ReferencedType) : GeneratedTypeBase(ReferencedType), IGeneratedType;
public abstract record class GeneratedTypeDeclarationBase(
    Type ReferencedType,
    List<IGeneratedType> BaseTypes,
    List<IGeneratedField> Fields,
    List<IGeneratedTypeDeclaration> NestedTypes
) : GeneratedTypeBase(ReferencedType), IGeneratedTypeDeclaration {
    public virtual void ResolveForwardDeclarations(Dictionary<Type, IGeneratedType> lookup) {
        foreach (GeneratedFieldBase field in Fields.OfType<GeneratedFieldBase>()) {
            field.ResolveForwardDeclarations(lookup);
        }
    }
}

public record class GeneratedTypeClassDeclaration(
    Type ReferencedType,
    List<IGeneratedType> BaseTypes,
    List<IGeneratedField> Fields,
    List<IGeneratedTypeDeclaration> NestedTypes
) : GeneratedTypeDeclarationBase(ReferencedType, BaseTypes, Fields, NestedTypes);

public record class GeneratedTypeEnumDeclaration(
    Type ReferencedType,
    List<IGeneratedType> BaseTypes,
    List<string> Names,
    List<long> Values
) : GeneratedTypeBase(ReferencedType), IGeneratedTypeDeclaration {
    public List<IGeneratedField> Fields => [];
    public List<IGeneratedTypeDeclaration> NestedTypes => [];
}

public record class GeneratedTypeInterfaceDeclaration(
    Type ReferencedType,
    List<IGeneratedType> BaseTypes
) : GeneratedTypeBase(ReferencedType), IGeneratedTypeDeclaration {
    public List<IGeneratedField> Fields => [];
    public List<IGeneratedTypeDeclaration> NestedTypes => [];
}

public record class GeneratedTypeStructDeclaration(
    Type ReferencedType,
    List<IGeneratedType> BaseTypes,
    List<IGeneratedField> Fields,
    List<IGeneratedTypeDeclaration> NestedTypes
) : GeneratedTypeDeclarationBase(ReferencedType, BaseTypes, Fields, NestedTypes);

public abstract record class GeneratedFieldBase : IGeneratedField {
    public GeneratedFieldBase(FieldInfo referencedField, IGeneratedType type, List<IGeneratedType> attributes) {
        ReferencedField = referencedField;
        Attributes = attributes;
        Type = type;
    }

    public FieldInfo ReferencedField { get; }
    public string Name => ReferencedField.Name;
    public IGeneratedType Type { get; private set; }
    public List<IGeneratedType> Attributes { get; }

    public virtual void ResolveForwardDeclarations(Dictionary<Type, IGeneratedType> lookup) {
        if (Type is GeneratedTypeForwardDecl) {
            Type = lookup[Type.ReferencedType];
        }
    }
}

public record class GeneratedField(
    FieldInfo ReferencedField,
    IGeneratedType Type,
    List<IGeneratedType> Attributes
) : GeneratedFieldBase(ReferencedField, Type, Attributes);

public record class GeneratedArrayField : GeneratedFieldBase {
    public GeneratedArrayField(FieldInfo referencedField, IGeneratedType type,  List<IGeneratedType> attributes,
        IGeneratedType arrayType, int arity) : base(referencedField, type, attributes)
    {
        ArrayType = arrayType;
        Arity = arity;
    }

    public IGeneratedType ArrayType { get; private set; }
    public int Arity { get; }

    public override void ResolveForwardDeclarations(Dictionary<Type, IGeneratedType> lookup) {
        base.ResolveForwardDeclarations(lookup);

        if (ArrayType is GeneratedTypeForwardDecl) {
            ArrayType = lookup[ArrayType.ReferencedType];
        }
    }
}

public record class GeneratedGenericField(
    FieldInfo ReferencedField,
    IGeneratedType Type,
    List<IGeneratedType> Attributes,
    List<IGeneratedType> GenericTypes
) : GeneratedFieldBase(ReferencedField, Type, Attributes) {
    public override void ResolveForwardDeclarations(Dictionary<Type, IGeneratedType> lookup) {
        base.ResolveForwardDeclarations(lookup);

        for (int i = 0; i < GenericTypes.Count; ++i) {
            if (GenericTypes[i] is GeneratedTypeForwardDecl) {
                GenericTypes[i] = lookup[GenericTypes[i].ReferencedType];
            }
        }
    }
}

public static class TypeGeneratorUtil {
    public static IGeneratedType CreateGeneratedType(Dictionary<Type, IGeneratedType> lookup, Type type) {
        if (!lookup.TryGetValue(type, out IGeneratedType? generatedType)) {
            lookup[type] = new GeneratedTypeForwardDecl(type);

            if (type.IsPrimitive) {
                generatedType = new GeneratedType(type);
            } else if (type.IsEnum) {
                generatedType = CreateEnum(type);
            } else if (type.IsInterface) {
                generatedType = CreateInterface(type);
            } else if (type.IsClass || type.IsValueType) {
                generatedType = CreateTypeWithFields(lookup, type);
            } else {
                generatedType = new GeneratedType(type);
            }

            lookup[type] = generatedType;
        }

        if (generatedType is GeneratedTypeDeclarationBase decl) {
            decl.ResolveForwardDeclarations(lookup);
        }

        return generatedType;
    }

    private static GeneratedTypeEnumDeclaration CreateEnum(Type type) {
        string[] names = type.GetEnumNames();
        Array values = type.GetEnumValuesAsUnderlyingType();
        return new GeneratedTypeEnumDeclaration(
            ReferencedType: type,
            BaseTypes: [],
            Names: [.. names],
            Values: [.. values.Cast<object>().Select(Convert.ToInt64)]
        );
    }

    private static IGeneratedField CreateField(Dictionary<Type, IGeneratedType> lookup, FieldInfo field) {
        IGeneratedType type = CreateGeneratedType(lookup, field.FieldType);
        List<IGeneratedType> attributes = [.. field.CustomAttributes.Select(x => CreateGeneratedType(lookup, x.AttributeType))];

        if (field.FieldType.IsArray) {
            IGeneratedType arrayType = CreateGeneratedType(lookup, field.FieldType.GetElementType()!);
            int arity = field.FieldType.GetArrayRank();
            return new GeneratedArrayField(field, type, attributes, arrayType, arity);
        }

        if (field.FieldType.IsGenericType) {
            List<IGeneratedType> genericTypes = [.. field.FieldType.GetGenericArguments().Select(x => CreateGeneratedType(lookup, x))];
            return new GeneratedGenericField(field, type, attributes, genericTypes);
        }

        return new GeneratedField(field, type, attributes);
    }

    private static IGeneratedTypeDeclaration CreateTypeWithFields(Dictionary<Type, IGeneratedType> lookup, Type type) {
        List<IGeneratedType> baseTypes = [
            type.BaseType != null ? CreateGeneratedType(lookup, type.BaseType) : null,
            .. type.GetInterfaces().Select(x => CreateGeneratedType(lookup, x))
        ];

        List<IGeneratedField> fields = [..type
            .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
            .Where(x => ShouldSerializeField(x) && ShouldSerializeFieldType(x.FieldType))
            .Select(x => CreateField(lookup, x))
        ];

        List<IGeneratedTypeDeclaration> nestedTypes = [..type
            .GetNestedTypes(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
            .Where(x => !x.CustomAttributes.Any(x => x.AttributeType.Name == nameof(CompilerGeneratedAttribute)))
            .Select(x => (IGeneratedTypeDeclaration)CreateGeneratedType(lookup, x))
        ];

        return type switch {
            { IsClass: true } => new GeneratedTypeClassDeclaration(type, baseTypes, fields, nestedTypes),
            { IsValueType: true } => new GeneratedTypeStructDeclaration(type, baseTypes, fields, nestedTypes),
            _ => throw new($"Unsupported type: {type}")
        };
    }

    private static GeneratedTypeInterfaceDeclaration CreateInterface(Type type) {
        return new GeneratedTypeInterfaceDeclaration(type, []);
    }

    public static void CollectListOfDeclaredTypes(IGeneratedTypeDeclaration type, List<IGeneratedTypeDeclaration> typesOut) {
        typesOut.AddRange(type);
        typesOut.AddRange(type.NestedTypes);

        foreach (IGeneratedTypeDeclaration nested in type.NestedTypes) {
            CollectListOfDeclaredTypes(nested, typesOut);
        }
    }

    public static void CollectListOfReferencedTypes(IGeneratedTypeDeclaration type, List<IGeneratedType> typesOut) {
        typesOut.AddRange(type.BaseTypes);
        typesOut.AddRange(type.Fields.Select(x => x.Type));
        typesOut.AddRange(type.Fields.OfType<GeneratedArrayField>().Select(x => x.ArrayType));
        typesOut.AddRange(type.Fields.OfType<GeneratedGenericField>().SelectMany(x => x.GenericTypes));

        foreach (IGeneratedTypeDeclaration nested in type.NestedTypes) {
            CollectListOfReferencedTypes(nested, typesOut);
        }
    }

    public static bool ShouldSerializeField(FieldInfo field) {
        // Is public, or has a SerializeField attribute
        // isn’t static
        // isn’t const
        // isn’t readonly

        bool isPublic = field.IsPublic;
        bool isNotSerializable = (field.Attributes & FieldAttributes.NotSerialized) != 0;
        bool isSerializable = field.CustomAttributes.Any(x => x.AttributeType.Name.EndsWith("SerializeField"));
        bool isStatic = field.IsStatic;
        bool isConst = field.IsLiteral;
        bool isReadonly = field.IsInitOnly;

        return ((isPublic || isSerializable) && !isNotSerializable) && !isStatic && !isConst && !isReadonly;
    }

    public static bool ShouldSerializeFieldType(Type type) {
        // Has a field type that can be serialized:
        // Primitive data types (int, float, double, bool, string, etc.)
        // Enum types (32 bites or smaller)
        // Fixed-size buffers
        // Unity built-in types, for example, Vector2, Vector3, Rect, Matrix4x4, Color, AnimationCurve
        // Custom structs with the Serializable attribute
        // References to objects that derive from UnityEngine.Object
        // Custom classes with the Serializable attribute. (See Serialization of custom classes).
        // An array of a field type mentioned above
        // A List<T> of a field type mentioned above

        CheckType(type, out bool isUnityObject, out bool isString, out Type? innerType);

        if (innerType != null) {
            type = innerType; // we need to check the inner type to see if it's serializable
            CheckType(innerType, out isUnityObject, out isString, out Type? typeInnerInnerType);
            if (typeInnerInnerType != null)
                return false;
        }

        bool isPrimitive = type.IsPrimitive || isString;
        bool isEnum = type.IsEnum;
        // TODO: Fixed size buffers?
        bool isBuiltIn = IsUnityEngineType(type);
        bool isSerializable = (type.Attributes & TypeAttributes.Serializable) != 0;
        bool isCollection = innerType != null;

        return isPrimitive || isEnum || isSerializable || isUnityObject || isCollection || isBuiltIn;
    }

    public static void CheckType(
        Type type,
        out bool isUnityObject,
        out bool isString,
        out Type? innerType) {
        isUnityObject = IsUnityObject(type);
        isString = type.FullName == typeof(string).FullName;
        bool isArray = type.IsArray || (type.IsGenericType && type.GetGenericTypeDefinition().FullName == typeof(List<>).FullName);
        innerType = isArray ? (type.IsArray ? type.GetElementType()! : type.GetGenericArguments().First()) : null;
    }

    public static bool IsUnityObject(Type? type) {
        while (type != null) {
            if (type.FullName == "UnityEngine.Object") {
                return true;
            }

            type = type.BaseType;
        }

        return false;
    }

    public static bool IsUnityEngineType(Type type) {
        if (type.Namespace == null) {
            return false;
        }

        if (_excludedUnityNamespaces.Contains(type.Namespace)) {
            return false;
        }

        return type.Namespace.StartsWith("UnityEngine");
    }

    public static bool IsUnityEngineBuiltInType(Type type) {
        return IsUnityEngineType(type) && _builtInTypeNames.Contains(type.Name);
    }

    private static HashSet<string> _builtInTypeNames = [
        "AnimationCurve",
        "Bounds",
        "Color",
        "Color32",
        "Gradient",
        "Keyframe",
        "LayerMask",
        "MonoBehaviour",
        "Object",
        "RectOffset",
        "Rect",
        "ScriptableObject",
        "Vector2",
        "Vector2Int",
        "Vector3",
        "Vector3Int",
        "Vector4",
        "Vector4Int"
    ];

    private static HashSet<string> _excludedUnityNamespaces = [
        "UnityEngine.UI.Extensions" // paid package? lmao the name
    ];
}
