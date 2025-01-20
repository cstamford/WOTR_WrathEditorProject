using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class PenetrationAvoidance {
    public object avoiders /* RootMotion.FinalIK.Avoider[] */;

    public class Avoider {
        public global::UnityEngine.Transform[] raycastFrom /* UnityEngine.Transform[] */;
        public global::UnityEngine.Transform raycastTo /* UnityEngine.Transform */;
        public float raycastRadius /* System.Single */;
        public object effectors /* RootMotion.FinalIK.EffectorLink[] */;
        public float smoothTimeIn /* System.Single */;
        public float smoothTimeOut /* System.Single */;
        public global::UnityEngine.LayerMask layers /* UnityEngine.LayerMask */;

        public class EffectorLink {
            public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
            public float weight /* System.Single */;
        }

    }

}

}

