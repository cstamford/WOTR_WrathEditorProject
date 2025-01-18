using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapKingdom : MonoBehaviour {
    [SerializeField] public Image m_Fx /* UnityEngine.UI.Image */;
    [SerializeField] public Button m_EnterBtn /* UnityEngine.UI.Button */;
    [SerializeField] public object m_EnterLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Color m_EnableColor /* UnityEngine.Color */;
    [SerializeField] public Color m_DisableColor /* UnityEngine.Color */;
    [SerializeField] public TooltipTrigger m_TooltipTrigger /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public Image m_NoneBorderStateIcon /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_AllBorderStateIcon /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_OnlyBorderStateIcon /* UnityEngine.UI.Image */;
}

}

