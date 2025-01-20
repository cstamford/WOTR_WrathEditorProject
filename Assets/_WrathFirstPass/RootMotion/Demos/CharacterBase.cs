using System;
using UnityEngine;

namespace RootMotion.Demos {

public class CharacterBase : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.Transform gravityTarget /* UnityEngine.Transform */;
    [SerializeField] public float gravityMultiplier /* System.Single */;
    [SerializeField] public float airborneThreshold /* System.Single */;
    [SerializeField] public float slopeStartAngle /* System.Single */;
    [SerializeField] public float slopeEndAngle /* System.Single */;
    [SerializeField] public float spherecastRadius /* System.Single */;
    [SerializeField] public global::UnityEngine.LayerMask groundLayers /* UnityEngine.LayerMask */;
}

}

