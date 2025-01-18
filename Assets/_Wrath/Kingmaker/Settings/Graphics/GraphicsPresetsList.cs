using UnityEngine;

namespace Kingmaker.Settings.Graphics {

public class GraphicsPresetsList : ScriptableObject {
    [SerializeField] public object m_GraphicsPresets /* Kingmaker.Settings.Graphics.GraphicsPresetAsset[] */;
    [SerializeField] public GraphicsPresetAsset m_ConsoleGraphicsPreset /* Kingmaker.Settings.Graphics.GraphicsPresetAsset */;
    [SerializeField] public GraphicsPresetAsset m_ConsoleMediumGraphicsPreset /* Kingmaker.Settings.Graphics.GraphicsPresetAsset */;
    [SerializeField] public GraphicsPresetAsset m_ConsoleHighGraphicsPreset /* Kingmaker.Settings.Graphics.GraphicsPresetAsset */;
}

}

