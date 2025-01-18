using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Kingmaker.Visual.DayNightCycle {

public class SceneLightConfig : ScriptableObject {
    public Vector3 MainLightRotation /* UnityEngine.Vector3 */;
    public Color MainLightColor /* UnityEngine.Color */;
    public float MainLightIntensity /* System.Single */;
    public float MainLightIndirectIntensity /* System.Single */;
    public float MainLightShadowStrength /* System.Single */;
    public Color SkyAmbientColor /* UnityEngine.Color */;
    public Color EquatorAmbientColor /* UnityEngine.Color */;
    public Color GroundAmbientColor /* UnityEngine.Color */;
    public Color SkyboxSkyTint /* UnityEngine.Color */;
    public Color SkyboxGround /* UnityEngine.Color */;
    public float SkyboxExposure /* System.Single */;
    public Color FogColor /* UnityEngine.Color */;
    public float FogStartDistance /* System.Single */;
    public float FogEndDistance /* System.Single */;
    public VolumeProfile PpProfile /* UnityEngine.Rendering.VolumeProfile */;
}

}

