using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomStatContentStatsStat : MonoBehaviour {
    [SerializeField] public Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Footer /* UnityEngine.UI.Image */;
    [SerializeField] public object m_NameStat /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Rank /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Slider m_ProgressBar /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_ToRankUpValue /* TMPro.TextMeshProUGUI */;
}

}

