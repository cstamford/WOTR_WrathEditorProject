using Kingmaker.UI.Kingdom;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.KingdomRaven {

public class KingdomRaventTotalChanged : MonoBehaviour {
    [SerializeField] public object m_TotalBPText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerPeriodText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TotalBPPerWeekText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerWeekPerPeriodText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RectTransform m_StatsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
    [SerializeField] public object m_UnrestLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_UnrestUp /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_UnrestDown /* UnityEngine.UI.Image */;
}

}

