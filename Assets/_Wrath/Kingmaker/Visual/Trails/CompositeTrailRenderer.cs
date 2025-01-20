using System;
using UnityEngine;

namespace Kingmaker.Visual.Trails {

public class CompositeTrailRenderer : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.Material Material /* UnityEngine.Material */;
    public global::UnityEngine.Transform ProbeAnchor /* UnityEngine.Transform */;
    public bool UseLightProbes /* System.Boolean */;
    public float Lifetime /* System.Single */;
    public global::Kingmaker.Visual.Trails.CompositeTrailRenderer.TrailAlignment Alignment /* Kingmaker.Visual.Trails.TrailAlignment */;
    public global::UnityEngine.Space UvSpace /* UnityEngine.Space */;
    [SerializeField] public float m_MinVertexDistance /* System.Single */;
    public global::UnityEngine.Vector3 PointVelocity /* UnityEngine.Vector3 */;
    public global::UnityEngine.Gradient ColorOverLifetime /* UnityEngine.Gradient */;
    public global::UnityEngine.Gradient ColorOverLength /* UnityEngine.Gradient */;
    public float MaxColorLenght /* System.Single */;
    public global::UnityEngine.Color MultiplyColor /* UnityEngine.Color */;
    public float Width /* System.Single */;
    public global::UnityEngine.AnimationCurve WidthOverLifetime /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.AnimationCurve WidthOverLength /* UnityEngine.AnimationCurve */;
    public float MaxLength /* System.Single */;
    public global::Kingmaker.Visual.Trails.CompositeTrailRenderer.CurveMode OffsetCurveMode /* Kingmaker.Visual.Trails.CurveMode */;
    public object OffsetCurveRandom /* Kingmaker.Visual.Entry */;
    public object OffsetCurve /* Kingmaker.Visual.CompositeAnimationCurve */;
    public object Emitters /* System.Collections.Generic.List */;

    public enum TrailAlignment {
        View = 0,
        World = 1,
    }

    public enum CurveMode {
        Lifetime = 0,
        Length = 1,
    }

}

}

