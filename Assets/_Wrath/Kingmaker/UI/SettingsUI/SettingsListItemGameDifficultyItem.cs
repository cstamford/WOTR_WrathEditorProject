using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SettingsUI {

public class SettingsListItemGameDifficultyItem : MonoBehaviour {
    [SerializeField] public Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_DifficultyName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Toggle m_Toggle /* UnityEngine.UI.Toggle */;
    public TooltipTrigger Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

