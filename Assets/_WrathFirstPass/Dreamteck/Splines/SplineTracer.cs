using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineTracer : global::Dreamteck.Splines.SplineUser {
    public bool applyDirectionRotation /* System.Boolean */;
    [SerializeField] public object _direction /* Dreamteck.Splines.Direction */;
    [SerializeField] public global::Dreamteck.Splines.SplineTracer.PhysicsMode _physicsMode /* Dreamteck.Splines.PhysicsMode */;
    [SerializeField] public object _motion /* Dreamteck.Splines.TransformModule */;
    [SerializeField] public object triggers_old /* Dreamteck.Splines.SplineTrigger[] */;
    public object triggers /* Dreamteck.Splines.Trigger[] */;
    [SerializeField] public object _customRotations /* Dreamteck.Splines.CustomRotationModule */;
    [SerializeField] public object _customOffsets /* Dreamteck.Splines.CustomOffsetModule */;
    [SerializeField] public global::UnityEngine.Rigidbody targetRigidbody /* UnityEngine.Rigidbody */;
    [SerializeField] public global::UnityEngine.Rigidbody2D targetRigidbody2D /* UnityEngine.Rigidbody2D */;
    [SerializeField] public global::UnityEngine.Transform targetTransform /* UnityEngine.Transform */;
    [SerializeField] public object _result /* Dreamteck.Splines.SplineResult */;

    public enum PhysicsMode {
        Transform = 0,
        Rigidbody = 1,
        Rigidbody2D = 2,
    }

}

}

