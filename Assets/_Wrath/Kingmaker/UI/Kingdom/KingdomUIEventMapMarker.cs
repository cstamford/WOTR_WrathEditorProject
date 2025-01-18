using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventMapMarker : MonoBehaviour {
    [SerializeField] public Transform m_Anchor /* UnityEngine.Transform */;
    [SerializeField] public Transform m_AnchorWithLeader /* UnityEngine.Transform */;
    [SerializeField] public GameObject m_LeaderObject /* UnityEngine.GameObject */;
    [SerializeField] public SpriteRenderer m_Portrait /* UnityEngine.SpriteRenderer */;
    [SerializeField] public object m_Highlighter /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Highlighting.Highlighter */;
    [SerializeField] public Transform m_AnimObject /* UnityEngine.Transform */;
}

}

