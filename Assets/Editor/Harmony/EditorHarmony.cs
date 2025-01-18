using HarmonyLib;
using System;

public static class EditorHarmony {
    [InvokeOnEditorLoad(-1)]
    private static void SetupHarmony() {
        _editorHarmony ??= new Harmony(_harmonyId);
        _editorHarmony.PatchAll();
    }
    
    [InvokeOnEditorUnload(1)]
    private static void CleanupHarmony() {
        _editorHarmony?.UnpatchAll(_harmonyId);
        _editorHarmony = null;
    }

    private const string _harmonyId = "com.wrath.editor";
    private static Harmony _editorHarmony;
    private static Action _harmonyCleanup;
}
