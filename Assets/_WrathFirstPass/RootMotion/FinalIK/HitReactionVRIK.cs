using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class HitReactionVRIK {
    public global::UnityEngine.AnimationCurve[] offsetCurves /* UnityEngine.AnimationCurve[] */;
    public object positionOffsets /* RootMotion.FinalIK.PositionOffset[] */;
    public object rotationOffsets /* RootMotion.FinalIK.RotationOffset[] */;

    public class Offset {
        public string name /* System.String */;
        public global::UnityEngine.Collider collider /* UnityEngine.Collider */;
        [SerializeField] public float crossFadeTime /* System.Single */;
    }

    public class PositionOffset {
        public int forceDirCurveIndex /* System.Int32 */;
        public int upDirCurveIndex /* System.Int32 */;
        public object offsetLinks /* RootMotion.FinalIK.PositionOffsetLink[] */;

        public class PositionOffsetLink {
            public object positionOffset /* RootMotion.FinalIK.PositionOffset */;
            public float weight /* System.Single */;
        }

    }

    public class RotationOffset {
        public int curveIndex /* System.Int32 */;
        public object offsetLinks /* RootMotion.FinalIK.RotationOffsetLink[] */;

        public class RotationOffsetLink {
            public object rotationOffset /* RootMotion.FinalIK.RotationOffset */;
            public float weight /* System.Single */;
        }

    }

}

}

