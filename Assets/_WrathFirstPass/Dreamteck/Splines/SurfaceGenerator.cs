using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SurfaceGenerator : global::Dreamteck.Splines.MeshGenerator {
    [SerializeField] public float _expand /* System.Single */;
    [SerializeField] public float _extrude /* System.Single */;
    [SerializeField] public global::UnityEngine.Vector2 _sideUvScale /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.Vector2 _sideUvOffset /* UnityEngine.Vector2 */;
    [SerializeField] public global::Dreamteck.Splines.SplineComputer _extrudeComputer /* Dreamteck.Splines.SplineComputer */;
    [SerializeField] public object extrudeResults /* Dreamteck.Splines.SplineResult[] */;
    [SerializeField] public global::UnityEngine.Vector3[] identityVertices /* UnityEngine.Vector3[] */;
    [SerializeField] public global::UnityEngine.Vector3[] identityNormals /* UnityEngine.Vector3[] */;
    [SerializeField] public global::UnityEngine.Vector2[] projectedVerts /* UnityEngine.Vector2[] */;
    [SerializeField] public int[] capTris /* System.Int32[] */;
    [SerializeField] public int[] wallTris /* System.Int32[] */;
    [SerializeField] public double _extrudeFrom /* System.Double */;
    [SerializeField] public double _extrudeTo /* System.Double */;
    [SerializeField] public bool _uniformUvs /* System.Boolean */;
}

}

