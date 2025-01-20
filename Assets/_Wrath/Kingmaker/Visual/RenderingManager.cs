using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class RenderingManager : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.GameObject BackgroundCamera /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Background /* UnityEngine.GameObject */;
    public global::Kingmaker.Visual.RenderingManager.RimLightingSettings RimLighting /* Kingmaker.Visual.RimLightingSettings */;
    public bool HDR /* System.Boolean */;

    public struct RimLightingSettings {
        public global::UnityEngine.Color RimGlobalColor /* UnityEngine.Color */;
        public float RimGlobalIntensity /* System.Single */;
    }

}

}

