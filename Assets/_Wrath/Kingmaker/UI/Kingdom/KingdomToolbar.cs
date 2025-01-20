using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomToolbar : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomBuffsCollectionController m_BuffCollection /* Kingmaker.UI.Kingdom.KingdomBuffsCollectionController */;
    [SerializeField] public object m_State /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_StateUp /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_StateDown /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Motto /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Date /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Time /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_SkipTime /* UnityEngine.UI.Button */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_SkipTimeTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.RectTransform m_Clock /* UnityEngine.RectTransform */;
}

}

