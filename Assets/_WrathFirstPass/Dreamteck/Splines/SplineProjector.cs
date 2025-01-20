using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineProjector : global::Dreamteck.Splines.SplineTracer {
    [SerializeField] public global::Dreamteck.Splines.SplineProjector.Mode _mode /* Dreamteck.Splines.Mode */;
    [SerializeField] public bool _autoProject /* System.Boolean */;
    [SerializeField] public int _subdivide /* System.Int32 */;
    [SerializeField] public global::UnityEngine.Transform _projectTarget /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform applyTarget /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject _targetObject /* UnityEngine.GameObject */;
    [SerializeField] public object finalTarget /* Dreamteck.TS_Transform */;
    [SerializeField] public global::UnityEngine.Vector2 _offset /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.Vector3 _rotationOffset /* UnityEngine.Vector3 */;

    public enum Mode {
        Accurate = 0,
        Cached = 1,
    }

}

}

