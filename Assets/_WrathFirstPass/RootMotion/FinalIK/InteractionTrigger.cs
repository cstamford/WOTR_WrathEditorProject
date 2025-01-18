using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class InteractionTrigger : MonoBehaviour {
    public object ranges /* RootMotion.FinalIK.Range[] */;

    public class CharacterPosition {
        public bool use /* System.Boolean */;
        public Vector2 offset /* UnityEngine.Vector2 */;
        public float angleOffset /* System.Single */;
        public float maxAngle /* System.Single */;
        public float radius /* System.Single */;
        public bool orbit /* System.Boolean */;
        public bool fixYAxis /* System.Boolean */;
    }

    public class CameraPosition {
        public Collider lookAtTarget /* UnityEngine.Collider */;
        public Vector3 direction /* UnityEngine.Vector3 */;
        public float maxDistance /* System.Single */;
        public float maxAngle /* System.Single */;
        public bool fixYAxis /* System.Boolean */;
    }

    public class Range {
        [SerializeField] public string name /* System.String */;
        [SerializeField] public bool show /* System.Boolean */;
        public InteractionTrigger.CharacterPosition characterPosition /* RootMotion.FinalIK.CharacterPosition */;
        public InteractionTrigger.CameraPosition cameraPosition /* RootMotion.FinalIK.CameraPosition */;
        public object interactions /* RootMotion.FinalIK.Interaction[] */;

        public class Interaction {
            public InteractionObject interactionObject /* RootMotion.FinalIK.InteractionObject */;
            public object effectors /* RootMotion.FinalIK.FullBodyBipedEffector[] */;
        }

    }

}

}

