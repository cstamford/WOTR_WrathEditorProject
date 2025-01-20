using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class Inertia {
    public object bodies /* RootMotion.FinalIK.Body[] */;
    public object limits /* RootMotion.FinalIK.OffsetLimits[] */;

    public class Body {
        public global::UnityEngine.Transform transform /* UnityEngine.Transform */;
        public object effectorLinks /* RootMotion.FinalIK.EffectorLink[] */;
        public float speed /* System.Single */;
        public float acceleration /* System.Single */;
        public float matchVelocity /* System.Single */;
        public float gravity /* System.Single */;

        public class EffectorLink {
            public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
            public float weight /* System.Single */;
        }

    }

}

}

