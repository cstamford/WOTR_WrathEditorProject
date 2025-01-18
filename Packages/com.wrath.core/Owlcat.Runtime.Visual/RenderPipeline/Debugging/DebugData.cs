using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.Debugging {

public class DebugData : ScriptableObject {
    [SerializeField] public Shader m_DebugShader /* UnityEngine.Shader */;
    [SerializeField] public object m_LightingDebug /* Owlcat.Runtime.Visual.RenderPipeline.Debugging.LightingDebug */;
    [SerializeField] public object m_RenderingDebug /* Owlcat.Runtime.Visual.RenderPipeline.Debugging.RenderingDebug */;
    [SerializeField] public object m_TerrainDebug /* Owlcat.Runtime.Visual.RenderPipeline.Debugging.TerrainDebug */;
    [SerializeField] public object m_OverdrawDebug /* Owlcat.Runtime.Visual.RenderPipeline.Debugging.OverdrawDebug */;
    [SerializeField] public object m_IndirectRenderingDebug /* Owlcat.Runtime.Visual.RenderPipeline.Debugging.IndirectRenderingDebug */;
    [SerializeField] public object m_StencilDebug /* Owlcat.Runtime.Visual.RenderPipeline.Debugging.StencilDebug */;
}

}

