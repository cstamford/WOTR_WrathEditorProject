using System;
using UnityEngine;

namespace Kingmaker.Settings.Difficulty {

public class DifficultyPresetAsset : global::UnityEngine.ScriptableObject {
    public bool IsCustomMode /* System.Boolean */;
    public object Preset /* Kingmaker.Settings.Difficulty.DifficultyPreset */;
    public global::UnityEngine.Sprite Icon /* UnityEngine.Sprite */;
    public object LocalizedName /* Kingmaker.Localization.LocalizedString */;
    public object LocalizedDescription /* Kingmaker.Localization.LocalizedString */;
}

}

