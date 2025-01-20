using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class PolygonColliderGenerator : global::Dreamteck.Splines.SplineUser {
    [SerializeField] public global::Dreamteck.Splines.PolygonColliderGenerator.Type _type /* Dreamteck.Splines.Type */;
    [SerializeField] public float _size /* System.Single */;
    [SerializeField] public float _offset /* System.Single */;
    [SerializeField] public global::UnityEngine.PolygonCollider2D polygonCollider /* UnityEngine.PolygonCollider2D */;
    [SerializeField] public global::UnityEngine.Vector2[] vertices /* UnityEngine.Vector2[] */;
    public float updateRate /* System.Single */;

    public enum Type {
        Path = 0,
        Shape = 1,
    }

}

}

