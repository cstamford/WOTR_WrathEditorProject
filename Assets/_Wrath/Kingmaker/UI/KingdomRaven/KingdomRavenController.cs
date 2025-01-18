using Kingmaker.UI.Common.Animations;
using UnityEngine;

namespace Kingmaker.UI.KingdomRaven {

public class KingdomRavenController : MonoBehaviour {
    [SerializeField] public WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public GameObject m_EmptyEventHolder /* UnityEngine.GameObject */;
    [SerializeField] public object m_NeedToVisitTheThroneRoom /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomRavenEventItem m_EventItem /* Kingmaker.UI.KingdomRaven.KingdomRavenEventItem */;
    [SerializeField] public RectTransform m_EventsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public KingdomRaventTotalChanged m_TotalChanged /* Kingmaker.UI.KingdomRaven.KingdomRaventTotalChanged */;
}

}

