using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class EdgeWindowView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.MonoBehaviour m_BlockScreen /* UnityEngine.MonoBehaviour */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_WindowShowAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_WindowHoverAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.SizeAnimator m_WindowSizeAnimator /* Kingmaker.UI.Common.Animations.SizeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.ContentScroller m_ContentScroller /* Kingmaker.UI.MVVM._PCView.CharGen.ContentScroller */;
    [SerializeField] public global::UnityEngine.RectTransform m_ExternalContentRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_WindowParentTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.EdgeWindowButtonPCView m_EdgeWindowButton /* Kingmaker.UI.MVVM._PCView.CharGen.EdgeWindowButtonPCView */;
    [SerializeField] public global::UnityEngine.Vector2 m_LeftAndRightPadding /* UnityEngine.Vector2 */;
    [SerializeField] public float m_HoverReactionDelta /* System.Single */;
    [SerializeField] public bool m_TestEnabled /* System.Boolean */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.EdgeWindowView.EdgeWindowState m_PositionState /* Kingmaker.UI.MVVM._PCView.CharGen.EdgeWindowState */;
    [SerializeField] public float m_HiddenPositionX /* System.Single */;
    [SerializeField] public float m_ShowedPositionX /* System.Single */;
    [SerializeField] public float m_HiddenSize /* System.Single */;
    [SerializeField] public float m_ShowedSize /* System.Single */;

    public enum EdgeWindowState {
        Hidden = 0,
        HiddenHover = 1,
        Showed = 2,
    }

}

}

