using Kingmaker.UI.Kingdom;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.KingdomRaven {

public class KingdomRaventTotalChanged : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_TotalBPText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerPeriodText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TotalBPPerWeekText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerWeekPerPeriodText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_StatsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
    [SerializeField] public object m_UnrestLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_UnrestUp /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_UnrestDown /* UnityEngine.UI.Image */;
}

}

