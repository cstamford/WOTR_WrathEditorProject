using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class OffsetPose : MonoBehaviour {
    public object effectorLinks /* RootMotion.FinalIK.EffectorLink[] */;

    public class EffectorLink {
        public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
        public Vector3 offset /* UnityEngine.Vector3 */;
        public Vector3 pin /* UnityEngine.Vector3 */;
        public Vector3 pinWeight /* UnityEngine.Vector3 */;
    }

}

}

