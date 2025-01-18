using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

class EditorCustomSettings : ScriptableObject {
    public string PathToGameDir => GetOrCreateSettings()._pathToGameDir;

    [SettingsProvider]
    public static SettingsProvider CreateEditorCustomSettingsProvider() =>
        new SettingsProvider("Project/Wrath Settings", SettingsScope.User) {
            label = "Wrath Settings",
            guiHandler = ctx => {
                SerializedObject settings = new SerializedObject(GetOrCreateSettings());
                EditorGUILayout.PropertyField(settings.FindProperty("_pathToGameDir"), new GUIContent("Path to WotR directory"));
                settings.ApplyModifiedPropertiesWithoutUndo();
            },
            keywords = new HashSet<string>(new[] { "Path", "WoTR", "Wrath", "Game", "Dir" })
        };

    private static EditorCustomSettings GetOrCreateSettings() {
        EditorCustomSettings settings = AssetDatabase.LoadAssetAtPath<EditorCustomSettings>(AssetPath);
        if (settings == null) {
            settings = CreateInstance<EditorCustomSettings>();
            settings._pathToGameDir = "C:/Program Files (x86)/Steam/steamapps/common/Pathfinder Second Adventure";
            AssetDatabase.CreateAsset(settings, AssetPath);
            AssetDatabase.SaveAssets();
        }
        return settings;
    }

    private const string AssetPath = "Assets/Editor/EditorPreferences.asset";
    [SerializeField] private string _pathToGameDir;
}
