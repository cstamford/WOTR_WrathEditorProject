using AssemblyImporter;
using Microsoft.CodeAnalysis;
using System.Reflection;

if (args.Length != 2) {
    Console.WriteLine("Usage: <path to game dir> <path to output dir>");
    return;
}

string pathToGameDir = args[0];
string pathToOutputDir = args[1];
string pathToManagedDir = Path.Combine(pathToGameDir, "Wrath_Data", "Managed");

string[] assemblies = [
    "Assembly-CSharp",
    "Assembly-CSharp-firstpass"
];

PathAssemblyResolver resolver = new(Directory.GetFiles(pathToManagedDir, "*.dll"));
using MetadataLoadContext ctx = new(resolver, "mscorlib");

List<IGeneratedTypeDeclaration> generatedTypes = Pass1_CreateTypes(ctx, assemblies);
Pass2_StripUnreferencedNestedTypes(generatedTypes);

List<IGeneratedTypeDeclaration> declaredTypes = Pass3_GetDeclaredTypes(generatedTypes);
Pass4_ResolveForwardDeclarations(declaredTypes, generatedTypes);

foreach (IGeneratedTypeDeclaration gen in generatedTypes) {
    Pass5_SubstituteUnresolvedTypes(declaredTypes, gen);
}

HashSet<string> validPaths = [];

foreach (IGeneratedTypeDeclaration gen in generatedTypes) {
    validPaths.Add(WriteTypeToFile(gen, pathToOutputDir));
}

foreach (string file in Directory.GetFiles(pathToOutputDir, "*.cs", SearchOption.AllDirectories)) {
    if (!validPaths.Contains(file)) {
        Console.WriteLine($"Cleaning up stale file {file}");
        File.Delete(file);
    }
}

foreach (string dir in Directory.GetDirectories(pathToOutputDir, "*", SearchOption.AllDirectories)) {
    if (Directory.GetFiles(dir, "*.cs", SearchOption.AllDirectories).Length == 0) {
        Console.WriteLine($"Cleaning up empty directory {dir}");
        Directory.Delete(dir);
    }
}
static IEnumerable<Type> TryLoadTypesFromAssembly(MetadataLoadContext ctx, string assemblyName) {
    try {
        return ctx.LoadFromAssemblyName(assemblyName).GetTypes();
    } catch (Exception ex) {
        Console.WriteLine($"Failed to load types from {assemblyName}: {ex}");
        return [];
    }
}

static List<IGeneratedTypeDeclaration> Pass1_CreateTypes(MetadataLoadContext ctx, string[] assemblies) {
    Dictionary<Type, IGeneratedType> generatedTypeLookup = [];
    List<IGeneratedTypeDeclaration> generatedTypes = [];

    foreach (Type type in assemblies.SelectMany(x => TryLoadTypesFromAssembly(ctx, x))) {
        if (!type.IsGenericType && type.BaseType?.Name is "MonoBehaviour" or "ScriptableObject") {
            generatedTypes.Add((IGeneratedTypeDeclaration)GeneratedType.Create(generatedTypeLookup, type));
        }
    }

    return generatedTypes;
}

static void Pass2_StripUnreferencedNestedTypes(List<IGeneratedTypeDeclaration> generatedTypes) {
    List<IGeneratedType> referencedTypesList = [];

    foreach (IGeneratedTypeDeclaration gen in generatedTypes) {
        TypeGeneratorUtil.CollectListOfReferencedTypes(gen, referencedTypesList);
    }

    HashSet<Type> referencedTypesLookup = new(referencedTypesList.Select(x => x.ReferencedType));

    foreach (IGeneratedTypeDeclaration gen in generatedTypes) {
        gen.NestedTypes.RemoveAll(x => !referencedTypesLookup.Contains(x.ReferencedType));
    }

}

static List<IGeneratedTypeDeclaration> Pass3_GetDeclaredTypes(List<IGeneratedTypeDeclaration> generatedTypes) {
    List<IGeneratedTypeDeclaration> all = [];

    foreach (IGeneratedTypeDeclaration gen in generatedTypes) {
        TypeGeneratorUtil.CollectListOfDeclaredTypes(gen, all);
    }

    all = [.. all.DistinctBy(x => x.ReferencedType)];
    return all;
}

static void Pass4_ResolveForwardDeclarations(List<IGeneratedTypeDeclaration> declaredTypes, List<IGeneratedTypeDeclaration> generatedTypes) {
    foreach (IGeneratedTypeDeclaration gen in generatedTypes) {
    }
}

static void Pass5_SubstituteUnresolvedTypes(List<IGeneratedTypeDeclaration> declaredTypes, IGeneratedTypeDeclaration gen) {
    for (int i = 0; i < gen.BaseTypes.Count; ++i) {
        if (!IsTypeFullyResolved(declaredTypes, gen.BaseTypes[i])) {
            gen.BaseTypes[i] = new GeneratedTypeForwardDecl(gen.BaseTypes[i].ReferencedType);
        }
    }

    for (int i = 0; i < gen.Fields.Count; ++i) {
        IGeneratedField field = gen.Fields[i];

        if (!IsFieldTypeFullyResolved(declaredTypes, field)) {
            gen.Fields[i] = new GeneratedField(field.ReferencedField, new GeneratedTypeForwardDecl(field.Type.ReferencedType), field.Attributes);
        }
    }

    foreach (IGeneratedTypeDeclaration nested in gen.NestedTypes) {
        Pass5_SubstituteUnresolvedTypes(declaredTypes, nested);
    }
}

static bool IsFieldTypeFullyResolved(List<IGeneratedTypeDeclaration> declaredTypes, IGeneratedField field) => field switch {
    GeneratedGenericField gen => IsTypeFullyResolved(declaredTypes, gen.Type) && gen.GenericTypes.All(x => IsTypeFullyResolved(declaredTypes, x)),
    GeneratedArrayField arr => IsTypeFullyResolved(declaredTypes, arr.Type) && IsTypeFullyResolved(declaredTypes, arr.ArrayType),
    _ => TypeGeneratorUtil.IsUnityEngineBuiltInType(field.Type.ReferencedType) || IsTypeFullyResolved(declaredTypes, field.Type)
};

static bool IsTypeFullyResolved(List<IGeneratedTypeDeclaration> declaredTypes, IGeneratedType type) {
    if (declaredTypes.Any(x => x.ReferencedType == type.ReferencedType)) {
        return true;
    }

    return TypeGeneratorUtil.IsUnityEngineType(type.ReferencedType) || type.Namespace.StartsWith("System");
}

static string WriteTypeToFile(IGeneratedTypeDeclaration gen, string pathToOutputDir) {
    string path = gen.Namespace?.Replace(".", "\\") ?? string.Empty;
    string pathToFile = Path.Combine(pathToOutputDir, path, $"{gen.Name}.cs");

    if (!string.IsNullOrWhiteSpace(path)) {
        Directory.CreateDirectory(Path.Combine(pathToOutputDir, path));
    }

    // Check if the file already exists - if it does, load it and check if it's the same before writing.
    // We do this to avoid bumping the timestamp on the file if it hasn't changed, which would cause Unity to do a full reimport.
    string outputStr = GeneratedTypeFormatter.Format(gen);

    if (File.Exists(pathToFile) && File.ReadAllText(pathToFile) == outputStr) {
        return pathToFile;
    }

    Console.WriteLine($"Writing {gen.Name} to {pathToFile}");
    File.WriteAllText(pathToFile, outputStr);

    return pathToFile;
}
