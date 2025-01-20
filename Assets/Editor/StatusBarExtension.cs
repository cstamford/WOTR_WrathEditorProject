using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public static class StatusBarExtension {
    public static void OnGUI() {
        GUILayout.Label("[TODO] Cute streaming load bar here");
    }
}

[HarmonyPatch]
public static class StatusBarExtensionPatches {
    [HarmonyTranspiler, HarmonyPatch(_appStatusBarTypeName, "OldOnGUI")]
    private static IEnumerable<CodeInstruction> PatchCallToGUI(IEnumerable<CodeInstruction> instructions) => new CodeMatcher(instructions)
        .MatchStartForward(CodeMatch.Calls(AccessTools.Method(AppStatusBarType, "DrawDebuggerToggle")))
        .Insert(new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(StatusBarExtension), nameof(StatusBarExtension.OnGUI))))
        .InstructionEnumeration();

    private const string _appStatusBarTypeName = "UnityEditor.AppStatusBar";
    private static Type AppStatusBarType => AccessTools.TypeByName(_appStatusBarTypeName);
}
