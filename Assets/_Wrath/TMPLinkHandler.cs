using System;
using UnityEngine;
using UnityEngine.Events;

public class TMPLinkHandler : MonoBehaviour {
    [SerializeField] public bool m_Interactable /* System.Boolean */;
    [SerializeField] public bool m_ColorTransnition /* System.Boolean */;
    [SerializeField] public bool m_OverlayNormalColor /* System.Boolean */;
    [SerializeField] public Color m_NormalColor /* UnityEngine.Color */;
    [SerializeField] public Color m_HighlightedColor /* UnityEngine.Color */;
    [SerializeField] public bool m_HighlightedUnderline /* System.Boolean */;
    [SerializeField] public TMPLinkHandler.LinkEventData m_OnClick /* .LinkEventData */;
    [SerializeField] public TMPLinkHandler.LinkEventData m_OnEnter /* .LinkEventData */;
    [SerializeField] public TMPLinkHandler.LinkEventData m_OnHover /* .LinkEventData */;
    [SerializeField] public TMPLinkHandler.LinkEventData m_OnExit /* .LinkEventData */;

    public class LinkEventData : UnityEvent {
    }

}

