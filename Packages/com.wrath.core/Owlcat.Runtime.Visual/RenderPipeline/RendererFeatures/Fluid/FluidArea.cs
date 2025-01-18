using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Fluid {

public class FluidArea : MonoBehaviour {
    [SerializeField] public Bounds m_Bounds /* UnityEngine.Bounds */;
    [SerializeField] public object m_AmbientWindSettings /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Fluid.AmbientWindSettings */;
    [SerializeField] public object m_FluidFogSettings /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.Fluid.FluidFogSettings */;
    [SerializeField] public bool m_SetActiveOnEnable /* System.Boolean */;
}

}

