using Kingmaker.UI.Common.Animations;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomRecurrentRavenController : MonoBehaviour {
    [SerializeField] public WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_NeedToVisitTheThroneRoom /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RectTransform m_StatsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
}

}

