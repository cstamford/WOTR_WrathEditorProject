using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class OffsetModifier : global::UnityEngine.MonoBehaviour {
    public float weight /* System.Single */;
    public global::RootMotion.FinalIK.FullBodyBipedIK ik /* RootMotion.FinalIK.FullBodyBipedIK */;

    public class OffsetLimits {
        public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
        public float spring /* System.Single */;
        public bool x /* System.Boolean */;
        public bool y /* System.Boolean */;
        public bool z /* System.Boolean */;
        public float minX /* System.Single */;
        public float maxX /* System.Single */;
        public float minY /* System.Single */;
        public float maxY /* System.Single */;
        public float minZ /* System.Single */;
        public float maxZ /* System.Single */;
    }

}

}

