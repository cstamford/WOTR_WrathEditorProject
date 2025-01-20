using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapKingdom : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Image m_Fx /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Button m_EnterBtn /* UnityEngine.UI.Button */;
    [SerializeField] public object m_EnterLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_EnableColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_DisableColor /* UnityEngine.Color */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_TooltipTrigger /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.UI.Image m_NoneBorderStateIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_AllBorderStateIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_OnlyBorderStateIcon /* UnityEngine.UI.Image */;
}

}

