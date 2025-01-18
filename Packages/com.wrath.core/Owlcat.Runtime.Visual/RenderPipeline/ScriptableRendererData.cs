using System.Collections.Generic;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline {

public class ScriptableRendererData : ScriptableObject {
    [SerializeField] public List<ScriptableRendererFeature> m_RendererFeatures /* System.Collections.Generic.List<Owlcat.Runtime.Visual.RenderPipeline.ScriptableRendererFeature> */;
    [SerializeField] public List<ScriptableRendererFeature> m_ConsoleFeaturesOverride /* System.Collections.Generic.List<Owlcat.Runtime.Visual.RenderPipeline.ScriptableRendererFeature> */;
}

}

