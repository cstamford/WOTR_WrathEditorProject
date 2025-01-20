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

Dictionary<AssemblyType, List<string>> assemblies = new() {
    [AssemblyType.Original] = [
        "Assembly-CSharp"
    ],
    [AssemblyType.OriginalFirstPass] = [
        "Assembly-CSharp-firstpass"
    ],
    [AssemblyType.Package] = [
        //"Owlcat.Runtime.Core",
        //"Owlcat.Runtime.Hardware",
        //"Owlcat.Runtime.UI",
        //"Owlcat.Runtime.UniRx",
        //"Owlcat.Runtime.Validation",
        //"Owlcat.Runtime.Visual",
        //"Owlcat.SharedTypes",
    ]
};

Dictionary<string, AssemblyType> assemblyToAssemblyType = assemblies
    .SelectMany(x => x.Value.Select(y => (y, x.Key)))
    .ToDictionary(x => x.y, x => x.Key);

PathAssemblyResolver resolver = new(Directory.GetFiles(pathToManagedDir, "*.dll"));
using MetadataLoadContext ctx = new(resolver, "mscorlib");

Dictionary<string, Type[]> assemblyToLoadedTypes = assemblyToAssemblyType.ToDictionary(
    x => x.Key,
    x => TryLoadTypesFromAssembly(ctx, x.Key).ToArray()
);

Dictionary<Type, string> typeToAssembly = assemblyToLoadedTypes
    .SelectMany(x => x.Value.Select(y => (y, x.Key)))
    .ToDictionary(x => x.y, x => x.Key);

List<IGeneratedTypeDeclaration> allGeneratedTypes = CreateTypes(ctx, assemblyToLoadedTypes.Values.SelectMany(x => x));
StripUnreferencedNestedTypes(allGeneratedTypes);

List<IGeneratedTypeDeclaration> workingSet = GetWorkingSet(allGeneratedTypes);
List<IGeneratedTypeDeclaration> flattenedWorkingSet = GetFlattenedWorkingSet(workingSet);

foreach (IGeneratedTypeDeclaration gen in workingSet) {
    SwapMissingTypes(gen, flattenedWorkingSet);
}

Dictionary<string, IGeneratedTypeDeclaration> pathToTypeMap = workingSet.ToDictionary(
    x => {
        string assembly = typeToAssembly[x.ReferencedType];
        AssemblyType assemblyType = assemblyToAssemblyType[assembly];
        string[] directoryComponents = x.ReferencedType.Namespace?.Split('.') ?? [];

        if (assemblyType is AssemblyType.Package) {
            // Types in the assembly will typically start at the assembly root, e.g.:
            // Owlcat.Runtime.Core -> types in namespace Owlcat.Runtime.Core should start at the root of the assembly.

            string[] assemblyNameComponents = assembly.Split('.');
            int componentsToDrop = 0;

            while (componentsToDrop < Math.Min(directoryComponents.Length, assemblyNameComponents.Length) &&
                directoryComponents[componentsToDrop] == assemblyNameComponents[componentsToDrop])
            {
                ++componentsToDrop;
            }

            directoryComponents = directoryComponents[componentsToDrop..];
        }

        string basePath = assemblyType switch {
            AssemblyType.Original => "Assets/_Wrath",
            AssemblyType.OriginalFirstPass => "Assets/_WrathFirstPass",
            _ => $"Packages/com.wrath.core/{assembly}"
        };

        string folderPath = string.Join("/", directoryComponents);
        return Path.Combine(basePath, folderPath, $"{x.Name}.cs");
    },
    x => x
);

foreach ((string path, IGeneratedTypeDeclaration type) in pathToTypeMap) {
    string fullPath = Path.Combine(pathToOutputDir, path);
    Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);

    string output = GeneratedTypeFormatter.Format(type);
    if (File.Exists(fullPath) && File.ReadAllText(fullPath) == output) {
        // Check if the file already exists - if it does, load it and check if it's the same before writing.
        // We do this to avoid bumping the timestamp on the file if it hasn't changed, which would cause Unity to do a full reimport.
        continue;
    }

    Console.WriteLine($"Writing {type.Namespace}.{type.Name} to {fullPath}");
    File.WriteAllText(fullPath, output);
}


static IEnumerable<Type> TryLoadTypesFromAssembly(MetadataLoadContext ctx, string assemblyName) {
    try {
        return ctx.LoadFromAssemblyName(assemblyName).GetTypes();
    } catch (Exception ex) {
        Console.WriteLine($"Failed to load types from {assemblyName}: {ex}");
        return [];
    }
}

static List<IGeneratedTypeDeclaration> CreateTypes(MetadataLoadContext ctx, IEnumerable<Type> types) {
    Dictionary<Type, IGeneratedType> generatedTypeLookup = [];
    List<IGeneratedTypeDeclaration> generatedTypes = [];

    foreach (Type type in types) {
        if (!type.IsGenericType) {
            generatedTypes.Add((IGeneratedTypeDeclaration)GeneratedType.Create(generatedTypeLookup, type));
        }
    }

    return generatedTypes;
}

static void StripUnreferencedNestedTypes(List<IGeneratedTypeDeclaration> workingSet) {
    List<IGeneratedType> referencedTypesList = [];

    foreach (IGeneratedTypeDeclaration gen in workingSet) {
        TypeGeneratorUtil.CollectListOfReferencedTypes(gen, referencedTypesList);
    }

    HashSet<Type> referencedTypesLookup = new(referencedTypesList.Select(x => x.ReferencedType));

    foreach (IGeneratedTypeDeclaration type in workingSet) {
        type.NestedTypes.RemoveAll(x => !referencedTypesLookup.Contains(x.ReferencedType));
    }
}

static List<IGeneratedTypeDeclaration> GetWorkingSet(List<IGeneratedTypeDeclaration> allGeneratedTypes) {
    return [.. allGeneratedTypes.Where(x => x.HasBaseClass("MonoBehaviour") || x.HasBaseClass("ScriptableObject"))];
}

static List<IGeneratedTypeDeclaration> GetFlattenedWorkingSet(List<IGeneratedTypeDeclaration> workingSet) {
    List<IGeneratedTypeDeclaration> flattened = [];

    foreach (IGeneratedTypeDeclaration type in workingSet) {
        TypeGeneratorUtil.CollectListOfDeclaredTypes(type, flattened);
    }

    flattened = [.. flattened.DistinctBy(x => x.ReferencedType)];
    return flattened;
}

static void SwapMissingTypes(IGeneratedTypeDeclaration type, List<IGeneratedTypeDeclaration> flattenedWorkingSet) {
    for (int i = 0; i < type.BaseTypes.Count; ++i) {
        if (!IsTypeFullyResolved(type.BaseTypes[i], flattenedWorkingSet)) {
            type.BaseTypes[i] = new GeneratedTypeForwardDecl(type.BaseTypes[i].ReferencedType);
        }
    }

    for (int i = 0; i < type.Fields.Count; ++i) {
        IGeneratedField field = type.Fields[i];

        if (!IsFieldTypeFullyResolved(field, flattenedWorkingSet)) {
            type.Fields[i] = new GeneratedField(field.ReferencedField, new GeneratedTypeForwardDecl(field.Type.ReferencedType), field.Attributes);
        }
    }

    foreach (IGeneratedTypeDeclaration nested in type.NestedTypes) {
        SwapMissingTypes(nested, flattenedWorkingSet);
    }
}

static bool IsFieldTypeFullyResolved(IGeneratedField field, List<IGeneratedTypeDeclaration> flattenedWorkingSet) => field switch {
    GeneratedGenericField gen => IsTypeFullyResolved(gen.Type, flattenedWorkingSet) && gen.GenericTypes.All(x => IsTypeFullyResolved(x, flattenedWorkingSet)),
    GeneratedArrayField arr => IsTypeFullyResolved(arr.Type, flattenedWorkingSet) && IsTypeFullyResolved(arr.ArrayType, flattenedWorkingSet),
    _ => TypeGeneratorUtil.IsUnityEngineBuiltInType(field.Type.ReferencedType) || IsTypeFullyResolved(field.Type, flattenedWorkingSet)
};

static bool IsTypeFullyResolved(IGeneratedType type, List<IGeneratedTypeDeclaration> flattenedWorkingSet) {
    if (flattenedWorkingSet.Any(x => x.ReferencedType == type.ReferencedType)) {
        return true;
    }

    return TypeGeneratorUtil.IsUnityEngineType(type.ReferencedType) || type.Namespace.StartsWith("System");
}

enum AssemblyType {
    Original,
    OriginalFirstPass,
    Package
}