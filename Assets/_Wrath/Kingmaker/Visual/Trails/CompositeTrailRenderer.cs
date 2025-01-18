using System;
using UnityEngine;

namespace Kingmaker.Visual.Trails {

public class CompositeTrailRenderer : MonoBehaviour {
    public Material Material /* UnityEngine.Material */;
    public Transform ProbeAnchor /* UnityEngine.Transform */;
    public bool UseLightProbes /* System.Boolean */;
    public float Lifetime /* System.Single */;
    public CompositeTrailRenderer.TrailAlignment Alignment /* Kingmaker.Visual.Trails.TrailAlignment */;
    public Space UvSpace /* UnityEngine.Space */;
    [SerializeField] public float m_MinVertexDistance /* System.Single */;
    public Vector3 PointVelocity /* UnityEngine.Vector3 */;
    public Gradient ColorOverLifetime /* UnityEngine.Gradient */;
    public Gradient ColorOverLength /* UnityEngine.Gradient */;
    public float MaxColorLenght /* System.Single */;
    public Color MultiplyColor /* UnityEngine.Color */;
    public float Width /* System.Single */;
    public AnimationCurve WidthOverLifetime /* UnityEngine.AnimationCurve */;
    public AnimationCurve WidthOverLength /* UnityEngine.AnimationCurve */;
    public float MaxLength /* System.Single */;
    public CompositeTrailRenderer.CurveMode OffsetCurveMode /* Kingmaker.Visual.Trails.CurveMode */;
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

