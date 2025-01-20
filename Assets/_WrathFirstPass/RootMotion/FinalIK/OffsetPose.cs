using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class OffsetPose : global::UnityEngine.MonoBehaviour {
    public object effectorLinks /* RootMotion.FinalIK.EffectorLink[] */;

    public class EffectorLink {
        public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
        public global::UnityEngine.Vector3 offset /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 pin /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 pinWeight /* UnityEngine.Vector3 */;
    }

}

}

