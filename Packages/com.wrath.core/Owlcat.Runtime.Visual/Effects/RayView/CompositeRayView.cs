using System;
using System.Collections.Generic;
using UnityEngine;

namespace Owlcat.Runtime.Visual.Effects.RayView {

public class CompositeRayView : MonoBehaviour {
    public float VertexDistance /* System.Single */;
    public float DelayOnLastHit /* System.Single */;
    public object OnLastHit /* Owlcat.Runtime.Visual.Effects.RayView.RayAction */;
    public float DelayOnLastFadeOut /* System.Single */;
    public object OnLastFadeOut /* Owlcat.Runtime.Visual.Effects.RayView.RayAction */;
    public float DelayOnAnimationFinished /* System.Single */;
    public object OnAnimationFinished /* Owlcat.Runtime.Visual.Effects.RayView.RayAction */;
    public AnimationClip Animation /* UnityEngine.AnimationClip */;
    public AnimationCurve PlaneOffsetMain /* UnityEngine.AnimationCurve */;
    public object PlaneOffsetAdditional /* Owlcat.Runtime.Core.Math.CompositeAnimationCurve */;
    public AnimationCurve UpOffsetMain /* UnityEngine.AnimationCurve */;
    public object UpOffsetAdditional /* Owlcat.Runtime.Core.Math.CompositeAnimationCurve */;
    [SerializeField] public List<CompositeRayView.Emitter> m_Emitters /* System.Collections.Generic.List<Owlcat.Runtime.Visual.Effects.RayView.Emitter> */;

    public class Emitter {
        public Transform StartPoint /* UnityEngine.Transform */;
        public Transform EndPoint /* UnityEngine.Transform */;
        public Space OffsetSpace /* UnityEngine.Space */;
        public object UvOffset /* Unity.Mathematics.float2 */;
        public float OffsetCurveBias /* System.Single */;
        public float WidthScale /* System.Single */;
        public float FadeWidth /* System.Single */;
        public float FadeAlphaSpeed /* System.Single */;
        public float FadeUvSpeed /* System.Single */;
    }

}

}

