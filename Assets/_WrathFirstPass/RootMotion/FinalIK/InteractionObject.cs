using System;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK {

public class InteractionObject : MonoBehaviour {
    public Transform otherLookAtTarget /* UnityEngine.Transform */;
    public Transform otherTargetsRoot /* UnityEngine.Transform */;
    public Transform positionOffsetSpace /* UnityEngine.Transform */;
    public object weightCurves /* RootMotion.FinalIK.WeightCurve[] */;
    public object multipliers /* RootMotion.FinalIK.Multiplier[] */;
    public object events /* RootMotion.FinalIK.InteractionEvent[] */;

    public class InteractionEvent {
        public float time /* System.Single */;
        public bool pause /* System.Boolean */;
        public bool pickUp /* System.Boolean */;
        public object animations /* RootMotion.FinalIK.AnimatorEvent[] */;
        public object messages /* RootMotion.FinalIK.Message[] */;
        public UnityEvent unityEvent /* UnityEngine.Events.UnityEvent */;
    }

    public class Message {
        public string function /* System.String */;
        public GameObject recipient /* UnityEngine.GameObject */;
    }

    public class AnimatorEvent {
        public Animator animator /* UnityEngine.Animator */;
        public Animation animation /* UnityEngine.Animation */;
        public string animationState /* System.String */;
        public float crossfadeTime /* System.Single */;
        public int layer /* System.Int32 */;
        public bool resetNormalizedTime /* System.Boolean */;
    }

    public class WeightCurve {
        public InteractionObject.WeightCurve.Type type /* RootMotion.FinalIK.Type */;
        public AnimationCurve curve /* UnityEngine.AnimationCurve */;

        public enum Type {
            PositionWeight = 0,
            RotationWeight = 1,
            PositionOffsetX = 2,
            PositionOffsetY = 3,
            PositionOffsetZ = 4,
            Pull = 5,
            Reach = 6,
            RotateBoneWeight = 7,
            Push = 8,
            PushParent = 9,
            PoserWeight = 10,
        }

    }

    public class Multiplier {
        public InteractionObject.WeightCurve.Type curve /* RootMotion.FinalIK.Type */;
        public float multiplier /* System.Single */;
        public InteractionObject.WeightCurve.Type result /* RootMotion.FinalIK.Type */;
    }

}

}

