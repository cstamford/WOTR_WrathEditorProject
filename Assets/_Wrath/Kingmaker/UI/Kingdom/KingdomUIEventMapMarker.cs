using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventMapMarker : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Transform m_Anchor /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_AnchorWithLeader /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject m_LeaderObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.SpriteRenderer m_Portrait /* UnityEngine.SpriteRenderer */;
    [SerializeField] public object m_Highlighter /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Highlighting.Highlighter */;
    [SerializeField] public global::UnityEngine.Transform m_AnimObject /* UnityEngine.Transform */;
}

}

