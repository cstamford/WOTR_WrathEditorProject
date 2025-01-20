using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class PathGenerator : global::Dreamteck.Splines.MeshGenerator {
    [SerializeField] public int _slices /* System.Int32 */;
    [SerializeField] public bool _useShapeCurve /* System.Boolean */;
    [SerializeField] public global::UnityEngine.AnimationCurve _shape /* UnityEngine.AnimationCurve */;
    [SerializeField] public global::UnityEngine.AnimationCurve _lastShape /* UnityEngine.AnimationCurve */;
    [SerializeField] public float _shapeExposure /* System.Single */;
}

}

