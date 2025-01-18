using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline {

public class OwlcatAdditionalCameraData : MonoBehaviour {
    [SerializeField] public LayerMask m_VolumeLayerMask /* UnityEngine.LayerMask */;
    [SerializeField] public Transform m_VolumeTrigger /* UnityEngine.Transform */;
    [SerializeField] public bool m_RenderPostProcessing /* System.Boolean */;
    [SerializeField] public object m_Antialiasing /* Owlcat.Runtime.Visual.RenderPipeline.AntialiasingMode */;
    [SerializeField] public object m_AntialiasingQuality /* Owlcat.Runtime.Visual.RenderPipeline.AntialiasingQuality */;
    [SerializeField] public bool m_Dithering /* System.Boolean */;
    [SerializeField] public bool m_AllowLighting /* System.Boolean */;
    [SerializeField] public bool m_AllowDecals /* System.Boolean */;
    [SerializeField] public bool m_AllowDistortion /* System.Boolean */;
    [SerializeField] public bool m_AllowIndirectRendering /* System.Boolean */;
    [SerializeField] public bool m_AllowFog /* System.Boolean */;
    [SerializeField] public bool m_AllowVfxPreparation /* System.Boolean */;
    [SerializeField] public RenderTexture m_DepthTexture /* UnityEngine.RenderTexture */;
    [SerializeField] public object m_RendererFeaturesFlags /* System.Collections.Generic.List */;
}

}

