using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class Amplifier {
    public object bodies /* RootMotion.FinalIK.Body[] */;

    public class Body {
        public global::UnityEngine.Transform transform /* UnityEngine.Transform */;
        public global::UnityEngine.Transform relativeTo /* UnityEngine.Transform */;
        public object effectorLinks /* RootMotion.FinalIK.EffectorLink[] */;
        public float verticalWeight /* System.Single */;
        public float horizontalWeight /* System.Single */;
        public float speed /* System.Single */;

        public class EffectorLink {
            public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
            public float weight /* System.Single */;
        }

    }

}

}

