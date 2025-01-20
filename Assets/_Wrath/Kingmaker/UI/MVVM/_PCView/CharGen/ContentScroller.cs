using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class ContentScroller : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.RectTransform m_RootRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public global::UnityEngine.RectTransform m_ReferenceObjectsContainer /* UnityEngine.RectTransform */;
}

}

