using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class EdgeColliderGenerator : global::Dreamteck.Splines.SplineUser {
    [SerializeField] public float _offset /* System.Single */;
    [SerializeField] public global::UnityEngine.EdgeCollider2D edgeCollider /* UnityEngine.EdgeCollider2D */;
    [SerializeField] public global::UnityEngine.Vector2[] vertices /* UnityEngine.Vector2[] */;
    public float updateRate /* System.Single */;
}

}

