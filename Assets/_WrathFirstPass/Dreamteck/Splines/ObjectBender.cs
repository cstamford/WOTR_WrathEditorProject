using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class ObjectBender : global::Dreamteck.Splines.SplineUser {
    [SerializeField] public bool _bend /* System.Boolean */;
    public object bendProperties /* Dreamteck.Splines.BendProperty[] */;
    [SerializeField] public object bounds /* Dreamteck.TS_Bounds */;
    [SerializeField] public global::Dreamteck.Splines.ObjectBender.Axis _axis /* Dreamteck.Splines.Axis */;
    [SerializeField] public global::Dreamteck.Splines.ObjectBender.NormalMode _normalMode /* Dreamteck.Splines.NormalMode */;
    [SerializeField] public global::Dreamteck.Splines.ObjectBender.ForwardMode _forwardMode /* Dreamteck.Splines.ForwardMode */;
    [SerializeField] public global::UnityEngine.Vector3 _customNormal /* UnityEngine.Vector3 */;
    [SerializeField] public global::UnityEngine.Vector3 _customForward /* UnityEngine.Vector3 */;

    public enum Axis {
        X = 0,
        Y = 1,
        Z = 2,
    }

    public enum NormalMode {
        Spline = 0,
        Auto = 1,
        Custom = 2,
    }

    public enum ForwardMode {
        Spline = 0,
        Custom = 1,
    }

    public class BendProperty {
        public bool enabled /* System.Boolean */;
        public object transform /* Dreamteck.TS_Transform */;
        public bool applyRotation /* System.Boolean */;
        public bool applyScale /* System.Boolean */;
        public bool generateLightmapUVs /* System.Boolean */;
        [SerializeField] public bool _bendMesh /* System.Boolean */;
        [SerializeField] public bool _bendSpline /* System.Boolean */;
        [SerializeField] public bool _bendCollider /* System.Boolean */;
        public float colliderUpdateRate /* System.Single */;
        public global::UnityEngine.Vector3 originalPosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 originalScale /* UnityEngine.Vector3 */;
        public global::UnityEngine.Quaternion originalRotation /* UnityEngine.Quaternion */;
        public global::UnityEngine.Quaternion parentRotation /* UnityEngine.Quaternion */;
        public global::UnityEngine.Vector3 positionPercent /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3[] vertexPercents /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector3[] normals /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector3[] colliderVertexPercents /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector3[] colliderNormals /* UnityEngine.Vector3[] */;
        [SerializeField] public global::UnityEngine.Mesh originalMesh /* UnityEngine.Mesh */;
        [SerializeField] public global::UnityEngine.Mesh originalColliderMesh /* UnityEngine.Mesh */;
        [SerializeField] public global::UnityEngine.Mesh destinationMesh /* UnityEngine.Mesh */;
        [SerializeField] public global::UnityEngine.Mesh destinationColliderMesh /* UnityEngine.Mesh */;
        public object destinationSpline /* Dreamteck.Splines.Spline */;
        public global::UnityEngine.MeshFilter filter /* UnityEngine.MeshFilter */;
        public global::UnityEngine.MeshCollider collider /* UnityEngine.MeshCollider */;
        public global::Dreamteck.Splines.SplineComputer splineComputer /* Dreamteck.Splines.SplineComputer */;
        public global::UnityEngine.Vector3[] splinePointPercents /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector3[] primaryTangentPercents /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector3[] secondaryTangentPercents /* UnityEngine.Vector3[] */;
        [SerializeField] public bool parent /* System.Boolean */;
    }

}

}

