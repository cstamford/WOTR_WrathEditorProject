using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Decals {

public class DecalGeometryHolder : MonoBehaviour {
    public string UniqueId /* System.String */;
    public Decal Decal /* Kingmaker.Visual.Decals.Decal */;
    public Texture Texture /* UnityEngine.Texture */;
    public Texture2D ParametersTex /* UnityEngine.Texture2D */;
    public Material Material /* UnityEngine.Material */;
    public float UsedTextureMemory /* System.Single */;
    [SerializeField] public List<DecalGeometryHolder.RendererLmapIndex> m_LmapIndices /* System.Collections.Generic.List<Kingmaker.Visual.Decals.RendererLmapIndex> */;

    public class RendererLmapIndex {
        public MeshRenderer DecalRenderer /* UnityEngine.MeshRenderer */;
        public string SubstrateRendererDataId /* System.String */;
        public int SubstrateRendererIndex /* System.Int32 */;
    }

}

}

