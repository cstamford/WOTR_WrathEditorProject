using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline {

public class OwlcatAdditionalLightData : MonoBehaviour {
    [SerializeField] public bool m_UsePipelineSettings /* System.Boolean */;
    [SerializeField] public float m_InnerRadius /* System.Single */;
    [SerializeField] public object m_FalloffType /* Owlcat.Runtime.Visual.RenderPipeline.Lighting.LightFalloffType */;
    [SerializeField] public bool m_SnapSpecularToInnerRadius /* System.Boolean */;
}

}

