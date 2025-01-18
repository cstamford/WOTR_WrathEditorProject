using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class InteractionTarget : MonoBehaviour {
    public object effectorType /* RootMotion.FinalIK.FullBodyBipedEffector */;
    public object multipliers /* RootMotion.FinalIK.Multiplier[] */;
    public float interactionSpeedMlp /* System.Single */;
    public Transform pivot /* UnityEngine.Transform */;
    public Vector3 twistAxis /* UnityEngine.Vector3 */;
    public float twistWeight /* System.Single */;
    public float swingWeight /* System.Single */;
    public bool rotateOnce /* System.Boolean */;

    public class Multiplier {
        public InteractionObject.WeightCurve.Type curve /* RootMotion.FinalIK.Type */;
        public float multiplier /* System.Single */;
    }

}

}

