using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SettingsUI {

public class ToggleButton : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.Common.ScrollRectExtended.BoolEvent OnValueChanged /* Kingmaker.UI.Common.BoolEvent */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_OnToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public global::UnityEngine.UI.Image m_OnImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_OffToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public global::UnityEngine.UI.Image m_OffImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color32 EnableTextColor /* UnityEngine.Color32 */;
    [SerializeField] public global::UnityEngine.Color32 DisableTextColor /* UnityEngine.Color32 */;
}

}

