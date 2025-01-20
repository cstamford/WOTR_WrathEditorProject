using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Decals {

public class DecalGeometryHolder : global::UnityEngine.MonoBehaviour {
    public string UniqueId /* System.String */;
    public global::Kingmaker.Visual.Decals.Decal Decal /* Kingmaker.Visual.Decals.Decal */;
    public global::UnityEngine.Texture Texture /* UnityEngine.Texture */;
    public global::UnityEngine.Texture2D ParametersTex /* UnityEngine.Texture2D */;
    public global::UnityEngine.Material Material /* UnityEngine.Material */;
    public float UsedTextureMemory /* System.Single */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Decals.DecalGeometryHolder.RendererLmapIndex> m_LmapIndices /* System.Collections.Generic.List<Kingmaker.Visual.Decals.RendererLmapIndex> */;

    public class RendererLmapIndex {
        public global::UnityEngine.MeshRenderer DecalRenderer /* UnityEngine.MeshRenderer */;
        public string SubstrateRendererDataId /* System.String */;
        public int SubstrateRendererIndex /* System.Int32 */;
    }

}

}

