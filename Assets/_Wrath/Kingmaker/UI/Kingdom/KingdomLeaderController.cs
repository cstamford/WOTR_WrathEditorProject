using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomLeaderController : global::UnityEngine.MonoBehaviour {
    public object Type /* Kingmaker.Kingdom.LeaderType */;
    [SerializeField] public object m_Highlighter /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Highlighting.Highlighter */;
    [SerializeField] public global::UnityEngine.Transform m_Anchor /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_KneelAnchor /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.SpriteRenderer m_Portrait /* UnityEngine.SpriteRenderer */;
    [SerializeField] public global::UnityEngine.SpriteRenderer m_LeaderIcon /* UnityEngine.SpriteRenderer */;
}

}

