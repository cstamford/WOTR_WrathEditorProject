using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIChooseCompanionCharacter : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_NameCharacter /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_CurrentRole /* UnityEngine.GameObject */;
    [SerializeField] public object m_CurrentRoleName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_StatIcon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StatValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_StatTooltipTrigger /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.GameObject m_Event /* UnityEngine.GameObject */;
    [SerializeField] public object m_EventName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_EventDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_RedCorner /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_GreenCorner /* UnityEngine.GameObject */;
}

}

