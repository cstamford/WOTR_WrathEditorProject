using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellSlotItem : global::Kingmaker.UI.ServiceWindow.SpellItemBase {
    [SerializeField] public global::UnityEngine.UI.Image m_BaseFrame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_MainFrame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_HighlightHover /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.UI.Image m_HighlightHoverFrame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_HighlightIn /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.UI.Image m_HighlightInFrame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_HighlightOut /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.UI.Image m_HighlightOutFrame /* UnityEngine.UI.Image */;
    [SerializeField] public float m_Alpha /* System.Single */;
    [SerializeField] public global::UnityEngine.Sprite m_StandartFrameSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_StandartFrameSpriteHover /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_StandartFrameSpriteMark /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_DomainFrameSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_DomainFrameSpriteHover /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_DomainFrameSpriteMark /* UnityEngine.Sprite */;
    public global::UnityEngine.UI.Image DecorationBorder /* UnityEngine.UI.Image */;
}

}

