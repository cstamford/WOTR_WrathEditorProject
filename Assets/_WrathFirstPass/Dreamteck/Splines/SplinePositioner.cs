using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplinePositioner : global::Dreamteck.Splines.SplineTracer {
    [SerializeField] public global::UnityEngine.Transform _applyTransform /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject _targetObject /* UnityEngine.GameObject */;
    [SerializeField] public double _position /* System.Double */;
    [SerializeField] public float animPosition /* System.Single */;
    [SerializeField] public global::Dreamteck.Splines.SplinePositioner.Mode _mode /* Dreamteck.Splines.Mode */;

    public enum Mode {
        Percent = 0,
        Distance = 1,
    }

}

}

