using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomRecurrentRavenController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_NeedToVisitTheThroneRoom /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_StatsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
}

}

