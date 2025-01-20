using System;
using UnityEngine;

namespace Kingmaker.Settings.Graphics {

public class GraphicsPresetsList : global::UnityEngine.ScriptableObject {
    [SerializeField] public object m_GraphicsPresets /* Kingmaker.Settings.Graphics.GraphicsPresetAsset[] */;
    [SerializeField] public global::Kingmaker.Settings.Graphics.GraphicsPresetAsset m_ConsoleGraphicsPreset /* Kingmaker.Settings.Graphics.GraphicsPresetAsset */;
    [SerializeField] public global::Kingmaker.Settings.Graphics.GraphicsPresetAsset m_ConsoleMediumGraphicsPreset /* Kingmaker.Settings.Graphics.GraphicsPresetAsset */;
    [SerializeField] public global::Kingmaker.Settings.Graphics.GraphicsPresetAsset m_ConsoleHighGraphicsPreset /* Kingmaker.Settings.Graphics.GraphicsPresetAsset */;
}

}

