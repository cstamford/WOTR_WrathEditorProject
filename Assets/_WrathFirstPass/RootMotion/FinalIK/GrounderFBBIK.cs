using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class GrounderFBBIK {
    public global::RootMotion.FinalIK.FullBodyBipedIK ik /* RootMotion.FinalIK.FullBodyBipedIK */;
    public float spineBend /* System.Single */;
    public float spineSpeed /* System.Single */;
    public object spine /* RootMotion.FinalIK.SpineEffector[] */;

    public class SpineEffector {
        public object effectorType /* RootMotion.FinalIK.FullBodyBipedEffector */;
        public float horizontalWeight /* System.Single */;
        public float verticalWeight /* System.Single */;
    }

}

}

