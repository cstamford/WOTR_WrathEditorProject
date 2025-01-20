using System;
using UnityEngine;

namespace Kingmaker.Visual.Decals {

public class Decal : global::UnityEngine.MonoBehaviour {
    [SerializeField] public string m_RefMaterial /* System.String */;
    public float MaxAngle /* System.Single */;
    public float PushDistance /* System.Single */;
    public global::UnityEngine.LayerMask AffectedLayers /* UnityEngine.LayerMask */;
    public bool BakeSubstrate /* System.Boolean */;
    public bool ScreenSpaceDecalsReceiver /* System.Boolean */;
}

}

