using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SettingsUI {

public class ToggleButton : MonoBehaviour {
    public object OnValueChanged /* Kingmaker.UI.Common.BoolEvent */;
    [SerializeField] public Toggle m_OnToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public Image m_OnImage /* UnityEngine.UI.Image */;
    [SerializeField] public Toggle m_OffToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public Image m_OffImage /* UnityEngine.UI.Image */;
    [SerializeField] public Color32 EnableTextColor /* UnityEngine.Color32 */;
    [SerializeField] public Color32 DisableTextColor /* UnityEngine.Color32 */;
}

}

