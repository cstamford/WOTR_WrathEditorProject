using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class Recoil {
    public global::RootMotion.FinalIK.AimIK aimIK /* RootMotion.FinalIK.AimIK */;
    public bool aimIKSolvedLast /* System.Boolean */;
    public global::RootMotion.FinalIK.Recoil.Handedness handedness /* RootMotion.FinalIK.Handedness */;
    public bool twoHanded /* System.Boolean */;
    public global::UnityEngine.AnimationCurve recoilWeight /* UnityEngine.AnimationCurve */;
    public float magnitudeRandom /* System.Single */;
    public global::UnityEngine.Vector3 rotationRandom /* UnityEngine.Vector3 */;
    public global::UnityEngine.Vector3 handRotationOffset /* UnityEngine.Vector3 */;
    public float blendTime /* System.Single */;
    public object offsets /* RootMotion.FinalIK.RecoilOffset[] */;
    public global::UnityEngine.Quaternion rotationOffset /* UnityEngine.Quaternion */;

    public class RecoilOffset {
        public global::UnityEngine.Vector3 offset /* UnityEngine.Vector3 */;
        public float additivity /* System.Single */;
        public float maxAdditiveOffsetMag /* System.Single */;
        public object effectorLinks /* RootMotion.FinalIK.EffectorLink[] */;

        public class EffectorLink {
            public object effector /* RootMotion.FinalIK.FullBodyBipedEffector */;
            public float weight /* System.Single */;
        }

    }

    public enum Handedness {
        Right = 0,
        Left = 1,
    }

}

}

