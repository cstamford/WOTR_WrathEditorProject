using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindowFooterDetail : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_BpCost /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BpCostStartLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ToResolve /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Difficulty /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DifficultyChance /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SolutionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_SolutionTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.GameObject m_Changes /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
    [SerializeField] public global::UnityEngine.Transform m_StatContainer /* UnityEngine.Transform */;
    [SerializeField] public object m_BPOneTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerTurn /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_Separator /* UnityEngine.GameObject */;
}

}

