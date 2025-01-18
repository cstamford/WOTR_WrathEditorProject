using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.Data {

public class OwlcatRenderPipelineEditorResources : ScriptableObject {
    [SerializeField] public Material m_DefaultMaterial /* UnityEngine.Material */;
    [SerializeField] public Material m_DefaultDecalMaterial /* UnityEngine.Material */;
    [SerializeField] public Material m_DefaultFullScreenDecalMaterial /* UnityEngine.Material */;
    [SerializeField] public Material m_DefaultTerrainMaterial /* UnityEngine.Material */;
    [SerializeField] public Material m_DefaultParticlesMaterial /* UnityEngine.Material */;
    [SerializeField] public Material m_DefaultSkyboxMaterial /* UnityEngine.Material */;
    [SerializeField] public Material m_DefaultUIMaterial /* UnityEngine.Material */;
}

}

