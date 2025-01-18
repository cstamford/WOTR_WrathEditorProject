using System;
using UnityEngine;

namespace Kingmaker.Blueprints.Area {

public class AreaPartBounds : ScriptableObject {
    [SerializeField] public Bounds m_DefaultBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideMechanicBounds /* System.Boolean */;
    [SerializeField] public Bounds m_MechanicBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideFogOfWarBounds /* System.Boolean */;
    [SerializeField] public Bounds m_FogOfWarBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideLocalMapBounds /* System.Boolean */;
    [SerializeField] public Bounds m_LocalMapBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideCameraBounds /* System.Boolean */;
    [SerializeField] public Bounds m_DefaultCameraBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideCutsceneCameraBounds /* System.Boolean */;
    [SerializeField] public Bounds m_CutsceneCameraBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideLocationWeatherDataBounds /* System.Boolean */;
    [SerializeField] public Bounds m_LocationWeatherDataBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_OverrideNavmeshBounds /* System.Boolean */;
    [SerializeField] public Bounds m_NavmeshBounds /* UnityEngine.Bounds */;
    [SerializeField] public bool m_UseCameraBlockBounds /* System.Boolean */;
    [SerializeField] public Bounds[] m_CameraBlockBounds /* UnityEngine.Bounds[] */;
    [SerializeField] public float m_ShadowFalloff /* System.Single */;
    [SerializeField] public bool m_IsBlurEnabled /* System.Boolean */;
    [SerializeField] public object m_StaticMaskLink /* Kingmaker.ResourceLinks.Texture2DLink */;
    [SerializeField] public object m_FogOfWarBorderSettings /* Owlcat.Runtime.Visual.RenderPipeline.RendererFeatures.FogOfWar.BorderSettings */;
    [SerializeField] public object m_FogOfWarStartOptions /* Kingmaker.Blueprints.Area.FoWStartOptions */;
}

}

