using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.FogOfWar {

public class FogOfWarArea : MonoBehaviour {
    [SerializeField] public Bounds m_Bounds /* UnityEngine.Bounds */;
    [SerializeField] public float m_ShadowFalloff /* System.Single */;
    [SerializeField] public bool m_IsBlurEnabled /* System.Boolean */;
    [SerializeField] public object m_BorderSettings /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.FogOfWar.BorderSettings */;
    [SerializeField] public Texture2D m_StaticMask /* UnityEngine.Texture2D */;
    [SerializeField] public bool m_RevealOnStart /* System.Boolean */;
    [SerializeField] public bool m_SetActiveOnEnable /* System.Boolean */;
    [SerializeField] public bool m_ApplyShaderManually /* System.Boolean */;
    [SerializeField] public bool m_IsCheatOffFog /* System.Boolean */;
}

}

