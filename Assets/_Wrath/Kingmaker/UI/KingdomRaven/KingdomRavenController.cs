using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.KingdomRaven {

public class KingdomRavenController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public global::UnityEngine.GameObject m_EmptyEventHolder /* UnityEngine.GameObject */;
    [SerializeField] public object m_NeedToVisitTheThroneRoom /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.KingdomRaven.KingdomRavenEventItem m_EventItem /* Kingmaker.UI.KingdomRaven.KingdomRavenEventItem */;
    [SerializeField] public global::UnityEngine.RectTransform m_EventsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.KingdomRaven.KingdomRaventTotalChanged m_TotalChanged /* Kingmaker.UI.KingdomRaven.KingdomRaventTotalChanged */;
}

}

