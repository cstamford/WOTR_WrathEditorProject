using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class HitReaction {
    public object effectorHitPoints /* RootMotion.FinalIK.HitPointEffector[] */;
    public object boneHitPoints /* RootMotion.FinalIK.HitPointBone[] */;

    public class HitPoint {
        public string name /* System.String */;
        public global::UnityEngine.Collider collider /* UnityEngine.Collider */;
        [SerializeField] public float crossFadeTime /* System.Single */;
    }

    public class HitPointEffector {
        public global::UnityEngine.AnimationCurve offsetInForceDirection /* UnityEngine.AnimationCurve */;
        public global::UnityEngine.AnimationCurve offsetInUpDirection /* UnityEngine.AnimationCurve */;
        public object effectorLinks /* RootMotion.FinalIK.EffectorLink[] */;

        public class EffectorLink {
            public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
            public float weight /* System.Single */;
        }

    }

    public class HitPointBone {
        public global::UnityEngine.AnimationCurve aroundCenterOfMass /* UnityEngine.AnimationCurve */;
        public object boneLinks /* RootMotion.FinalIK.BoneLink[] */;

        public class BoneLink {
            public global::UnityEngine.Transform bone /* UnityEngine.Transform */;
            public float weight /* System.Single */;
        }

    }

}

}

