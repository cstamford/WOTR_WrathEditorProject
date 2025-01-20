using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class InteractionTrigger : global::UnityEngine.MonoBehaviour {
    public object ranges /* RootMotion.FinalIK.Range[] */;

    public class CharacterPosition {
        public bool use /* System.Boolean */;
        public global::UnityEngine.Vector2 offset /* UnityEngine.Vector2 */;
        public float angleOffset /* System.Single */;
        public float maxAngle /* System.Single */;
        public float radius /* System.Single */;
        public bool orbit /* System.Boolean */;
        public bool fixYAxis /* System.Boolean */;
    }

    public class CameraPosition {
        public global::UnityEngine.Collider lookAtTarget /* UnityEngine.Collider */;
        public global::UnityEngine.Vector3 direction /* UnityEngine.Vector3 */;
        public float maxDistance /* System.Single */;
        public float maxAngle /* System.Single */;
        public bool fixYAxis /* System.Boolean */;
    }

    public class Range {
        [SerializeField] public string name /* System.String */;
        [SerializeField] public bool show /* System.Boolean */;
        public global::RootMotion.FinalIK.InteractionTrigger.CharacterPosition characterPosition /* RootMotion.FinalIK.CharacterPosition */;
        public global::RootMotion.FinalIK.InteractionTrigger.CameraPosition cameraPosition /* RootMotion.FinalIK.CameraPosition */;
        public object interactions /* RootMotion.FinalIK.Interaction[] */;

        public class Interaction {
            public global::RootMotion.FinalIK.InteractionObject interactionObject /* RootMotion.FinalIK.InteractionObject */;
            public object effectors /* RootMotion.FinalIK.FullBodyBipedEffector[] */;
        }

    }

}

}

