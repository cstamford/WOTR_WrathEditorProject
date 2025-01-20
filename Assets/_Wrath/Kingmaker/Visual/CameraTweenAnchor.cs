using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class CameraTweenAnchor : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.Visual.CameraTweenAnchor.TweenData m_DefaultTween /* Kingmaker.Visual.TweenData */;
    [SerializeField] public object m_Tweens /* Kingmaker.Visual.TweenDataWithPrev[] */;

    public class TweenData {
        public float RubberBandPosition /* System.Single */;
        public float RubberBandRotation /* System.Single */;
        public float AnimationTime /* System.Single */;
        public bool UseEasing /* System.Boolean */;
        public bool SeparateCurves /* System.Boolean */;
        public VectorSpline PositionTrack /* .VectorSpline */;
        public global::UnityEngine.AnimationCurve PositionCurve /* UnityEngine.AnimationCurve */;
        public VectorSpline LootAtTrack /* .VectorSpline */;
        public global::UnityEngine.AnimationCurve LookAtCurve /* UnityEngine.AnimationCurve */;
    }

    public class TweenDataWithPrev : global::Kingmaker.Visual.CameraTweenAnchor.TweenData {
        public global::Kingmaker.Visual.CameraTweenAnchor PreviousAnchor /* Kingmaker.Visual.CameraTweenAnchor */;
    }

}

}

