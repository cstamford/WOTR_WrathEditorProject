using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class InteractionSystem : MonoBehaviour {
    public string targetTag /* System.String */;
    public float fadeInTime /* System.Single */;
    public float speed /* System.Single */;
    public float resetToDefaultsSpeed /* System.Single */;
    public Collider characterCollider /* UnityEngine.Collider */;
    public Transform FPSCamera /* UnityEngine.Transform */;
    public LayerMask camRaycastLayers /* UnityEngine.LayerMask */;
    public float camRaycastDistance /* System.Single */;
    public RaycastHit raycastHit /* UnityEngine.RaycastHit */;
    [SerializeField] public object fullBody /* RootMotion.FinalIK.FullBodyBipedIK */;
    public object lookAt /* RootMotion.FinalIK.InteractionLookAt */;
}

}

