using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUILeaderCharacterController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_Cross /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Button m_PortraitButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Image m_StatIcon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StatName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_TooltipStat /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.GameObject m_Event /* UnityEngine.GameObject */;
    [SerializeField] public object m_EventName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_EventDescription /* TMPro.TextMeshProUGUI */;
}

}

