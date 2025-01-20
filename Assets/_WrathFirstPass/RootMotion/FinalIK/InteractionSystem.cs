using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class InteractionSystem : global::UnityEngine.MonoBehaviour {
    public string targetTag /* System.String */;
    public float fadeInTime /* System.Single */;
    public float speed /* System.Single */;
    public float resetToDefaultsSpeed /* System.Single */;
    public global::UnityEngine.Collider characterCollider /* UnityEngine.Collider */;
    public global::UnityEngine.Transform FPSCamera /* UnityEngine.Transform */;
    public global::UnityEngine.LayerMask camRaycastLayers /* UnityEngine.LayerMask */;
    public float camRaycastDistance /* System.Single */;
    public global::UnityEngine.RaycastHit raycastHit /* UnityEngine.RaycastHit */;
    [SerializeField] public global::RootMotion.FinalIK.FullBodyBipedIK fullBody /* RootMotion.FinalIK.FullBodyBipedIK */;
    public object lookAt /* RootMotion.FinalIK.InteractionLookAt */;
}

}

