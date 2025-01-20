using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class MeshGenerator : global::Dreamteck.Splines.SplineUser {
    [SerializeField] public bool _baked /* System.Boolean */;
    [SerializeField] public float _size /* System.Single */;
    [SerializeField] public global::UnityEngine.Color _color /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Vector3 _offset /* UnityEngine.Vector3 */;
    [SerializeField] public int _normalMethod /* System.Int32 */;
    [SerializeField] public bool _tangents /* System.Boolean */;
    [SerializeField] public float _rotation /* System.Single */;
    [SerializeField] public bool _flipFaces /* System.Boolean */;
    [SerializeField] public bool _doubleSided /* System.Boolean */;
    [SerializeField] public global::Dreamteck.Splines.MeshGenerator.UVMode _uvMode /* Dreamteck.Splines.UVMode */;
    [SerializeField] public global::UnityEngine.Vector2 _uvScale /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.Vector2 _uvOffset /* UnityEngine.Vector2 */;
    [SerializeField] public float _uvRotation /* System.Single */;
    [SerializeField] public global::UnityEngine.MeshCollider meshCollider /* UnityEngine.MeshCollider */;
    [SerializeField] public global::UnityEngine.MeshFilter filter /* UnityEngine.MeshFilter */;
    [SerializeField] public global::UnityEngine.MeshRenderer meshRenderer /* UnityEngine.MeshRenderer */;
    [SerializeField] public global::UnityEngine.Mesh mesh /* UnityEngine.Mesh */;
    public float colliderUpdateRate /* System.Single */;

    public enum UVMode {
        Clip = 0,
        UniformClip = 1,
        Clamp = 2,
        UniformClamp = 3,
    }

}

}

