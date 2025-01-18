using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomLeaderController : MonoBehaviour {
    public object Type /* Kingmaker.Kingdom.LeaderType */;
    [SerializeField] public object m_Highlighter /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Highlighting.Highlighter */;
    [SerializeField] public Transform m_Anchor /* UnityEngine.Transform */;
    [SerializeField] public Transform m_KneelAnchor /* UnityEngine.Transform */;
    [SerializeField] public SpriteRenderer m_Portrait /* UnityEngine.SpriteRenderer */;
    [SerializeField] public SpriteRenderer m_LeaderIcon /* UnityEngine.SpriteRenderer */;
}

}

