using Kingmaker.UI.Common.Animations;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class ContentScroller : MonoBehaviour {
    [SerializeField] public RectTransform m_RootRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public RectTransform m_ReferenceObjectsContainer /* UnityEngine.RectTransform */;
}

}

