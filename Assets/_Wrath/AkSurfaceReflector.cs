using System;
using UnityEngine;

public class AkSurfaceReflector : MonoBehaviour {
    public Mesh Mesh /* UnityEngine.Mesh */;
    public object AcousticTextures /* AK.Wwise.AcousticTexture[] */;
    public float[] OcclusionValues /* System.Single[] */;
    public bool EnableDiffraction /* System.Boolean */;
    public bool EnableDiffractionOnBoundaryEdges /* System.Boolean */;
    public object AssociatedRoom /* .AkRoom */;
    [SerializeField] public object AcousticTextureInternal /* AK.Wwise.AcousticTexture */;
}

