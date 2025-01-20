using System;
using UnityEngine;

namespace Kingmaker.Visual.Lightmapping {

public class LightmapStorage : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Chunks /* Kingmaker.Visual.Lightmapping.Chunk[] */;
    [SerializeField] public object m_Lightmaps /* Kingmaker.Visual.Lightmapping.LightmapData[] */;
    [SerializeField] public object m_BakedLightProbes /* Kingmaker.Visual.Lightmapping.SphericalHarmonics[] */;
    [SerializeField] public global::UnityEngine.LightProbes m_LightProbes /* UnityEngine.LightProbes */;

    public class RendererData {
        public int LightmapIndex /* System.Int32 */;
        public global::UnityEngine.Vector4 ScaleOffset /* UnityEngine.Vector4 */;
    }

    public class SphericalHarmonics {
        [SerializeField] public float[] Coefficients /* System.Single[] */;
    }

    public class LightmapData {
        public global::UnityEngine.Texture2D LightmapColor /* UnityEngine.Texture2D */;
        public global::UnityEngine.Texture2D LightmapDir /* UnityEngine.Texture2D */;
        public global::UnityEngine.Texture2D ShadowMask /* UnityEngine.Texture2D */;
    }

    public class Chunk {
        [SerializeField] public string RelatedRenderersDataId /* System.String */;
        [SerializeField] public object Renderers /* Kingmaker.Visual.Lightmapping.RendererData[] */;
    }

}

}

