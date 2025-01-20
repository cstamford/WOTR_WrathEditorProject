using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SettingsUI {

public class SettingsListItemGameDifficultyItem : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_DifficultyName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_Toggle /* UnityEngine.UI.Toggle */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

