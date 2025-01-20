using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Kingmaker.Visual.DayNightCycle {

public class SceneLightConfig : global::UnityEngine.ScriptableObject {
    public global::UnityEngine.Vector3 MainLightRotation /* UnityEngine.Vector3 */;
    public global::UnityEngine.Color MainLightColor /* UnityEngine.Color */;
    public float MainLightIntensity /* System.Single */;
    public float MainLightIndirectIntensity /* System.Single */;
    public float MainLightShadowStrength /* System.Single */;
    public global::UnityEngine.Color SkyAmbientColor /* UnityEngine.Color */;
    public global::UnityEngine.Color EquatorAmbientColor /* UnityEngine.Color */;
    public global::UnityEngine.Color GroundAmbientColor /* UnityEngine.Color */;
    public global::UnityEngine.Color SkyboxSkyTint /* UnityEngine.Color */;
    public global::UnityEngine.Color SkyboxGround /* UnityEngine.Color */;
    public float SkyboxExposure /* System.Single */;
    public global::UnityEngine.Color FogColor /* UnityEngine.Color */;
    public float FogStartDistance /* System.Single */;
    public float FogEndDistance /* System.Single */;
    public global::UnityEngine.Rendering.VolumeProfile PpProfile /* UnityEngine.Rendering.VolumeProfile */;
}

}

