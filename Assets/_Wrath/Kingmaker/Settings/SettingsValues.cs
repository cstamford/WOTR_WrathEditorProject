using Kingmaker.Settings.Difficulty;
using Kingmaker.Settings.Graphics;
using UnityEngine;

namespace Kingmaker.Settings {

public class SettingsValues : ScriptableObject {
    public object SettingsDefaultValues /* Kingmaker.Settings.SettingsDefaultValues */;
    public DifficultyPresetsList DifficultiesPresets /* Kingmaker.Settings.Difficulty.DifficultyPresetsList */;
    public GraphicsPresetsList GraphicsPresetsList /* Kingmaker.Settings.Graphics.GraphicsPresetsList */;
}

}

