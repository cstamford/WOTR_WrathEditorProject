using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class RenderingManager : MonoBehaviour {
    public GameObject BackgroundCamera /* UnityEngine.GameObject */;
    public GameObject Background /* UnityEngine.GameObject */;
    public RenderingManager.RimLightingSettings RimLighting /* Kingmaker.Visual.RimLightingSettings */;
    public bool HDR /* System.Boolean */;

    public struct RimLightingSettings {
        public Color RimGlobalColor /* UnityEngine.Color */;
        public float RimGlobalIntensity /* System.Single */;
    }

}

}

