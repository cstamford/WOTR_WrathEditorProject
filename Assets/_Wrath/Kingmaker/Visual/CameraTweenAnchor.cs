using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class CameraTweenAnchor : MonoBehaviour {
    [SerializeField] public CameraTweenAnchor.TweenData m_DefaultTween /* Kingmaker.Visual.TweenData */;
    [SerializeField] public object m_Tweens /* Kingmaker.Visual.TweenDataWithPrev[] */;

    public class TweenData {
        public float RubberBandPosition /* System.Single */;
        public float RubberBandRotation /* System.Single */;
        public float AnimationTime /* System.Single */;
        public bool UseEasing /* System.Boolean */;
        public bool SeparateCurves /* System.Boolean */;
        public object PositionTrack /* .VectorSpline */;
        public AnimationCurve PositionCurve /* UnityEngine.AnimationCurve */;
        public object LootAtTrack /* .VectorSpline */;
        public AnimationCurve LookAtCurve /* UnityEngine.AnimationCurve */;
    }

    public class TweenDataWithPrev : CameraTweenAnchor.TweenData {
        public object PreviousAnchor /* Kingmaker.Visual.CameraTweenAnchor */;
    }

}

}

