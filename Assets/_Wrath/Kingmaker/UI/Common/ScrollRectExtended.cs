using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class ScrollRectExtended {
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public bool m_Horizontal /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.Graphic m_LeftEdge /* UnityEngine.UI.Graphic */;
    [SerializeField] public global::UnityEngine.UI.Graphic m_RightEdge /* UnityEngine.UI.Graphic */;
    [SerializeField] public bool m_Vertical /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.Graphic m_TopEdge /* UnityEngine.UI.Graphic */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.BoolEvent m_OnReachedTopEdge /* Kingmaker.UI.Common.BoolEvent */;
    [SerializeField] public global::UnityEngine.UI.Graphic m_BottomEdge /* UnityEngine.UI.Graphic */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.BoolEvent m_OnReachedBottomEdge /* Kingmaker.UI.Common.BoolEvent */;
    [SerializeField] public float m_EdgeVisibleThreshold /* System.Single */;
    [SerializeField] public bool m_InvertedWheelScroll /* System.Boolean */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.MovementType m_MovementType /* Kingmaker.UI.Common.MovementType */;
    [SerializeField] public float m_Elasticity /* System.Single */;
    [SerializeField] public bool m_Inertia /* System.Boolean */;
    [SerializeField] public float m_DecelerationRate /* System.Single */;
    [SerializeField] public float m_ScrollSensitivity /* System.Single */;
    [SerializeField] public float m_ButtonScrollSensitivity /* System.Single */;
    [SerializeField] public global::UnityEngine.RectTransform m_Viewport /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Scrollbar m_HorizontalScrollbar /* UnityEngine.UI.Scrollbar */;
    [SerializeField] public bool m_HorizontalScrollbarSizeEffector /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.Scrollbar m_VerticalScrollbar /* UnityEngine.UI.Scrollbar */;
    [SerializeField] public bool m_VerticalScrollbarSizeEffector /* System.Boolean */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.ScrollbarVisibleEvent IsScrollbarVisible /* Kingmaker.UI.Common.ScrollbarVisibleEvent */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.ScrollbarVisibility m_HorizontalScrollbarVisibility /* Kingmaker.UI.Common.ScrollbarVisibility */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.ScrollbarVisibility m_VerticalScrollbarVisibility /* Kingmaker.UI.Common.ScrollbarVisibility */;
    [SerializeField] public float m_HorizontalScrollbarSpacing /* System.Single */;
    [SerializeField] public float m_VerticalScrollbarSpacing /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended.ScrollRectEvent m_OnValueChanged /* Kingmaker.UI.Common.ScrollRectEvent */;
    [SerializeField] public bool m_IsDraggable /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.Button m_BeginButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_EndButton /* UnityEngine.UI.Button */;

    public class BoolEvent : global::UnityEngine.Events.UnityEvent {
    }

    public class ScrollbarVisibleEvent : global::UnityEngine.Events.UnityEvent {
    }

    public enum MovementType {
        Unrestricted = 0,
        Elastic = 1,
        Clamped = 2,
    }

    public enum ScrollbarVisibility {
        Permanent = 0,
        AutoHide = 1,
        AutoHideAndExpandViewport = 2,
    }

    public class ScrollRectEvent : global::UnityEngine.Events.UnityEvent {
    }

}

}

