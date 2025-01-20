using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class SnapControllerBase : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.Visual.Particles.SnapControllerBase m_RotatableCopy /* Kingmaker.Visual.Particles.SnapControllerBase */;
    [SerializeField] public bool m_IsRotatableCopy /* System.Boolean */;
    public object SnapType /* Kingmaker.Visual.Particles.ParticleSnapType */;
    public global::Kingmaker.Visual.Particles.SnapMapBase Map /* Kingmaker.Visual.Particles.SnapMapBase */;
    public bool SupressMapOverride /* System.Boolean */;
    public global::UnityEngine.AnimationCurve CameraOffsetScale /* UnityEngine.AnimationCurve */;
    public bool ApplySizeScale /* System.Boolean */;
    public bool ApplyLifetimeScale /* System.Boolean */;
    public bool ApplyRateOverTimeScale /* System.Boolean */;
    public bool ApplyBurstScale /* System.Boolean */;
    public bool PersistWhenDisabled /* System.Boolean */;
    public global::Kingmaker.Visual.Particles.SnapControllerBase.SnapOffset Offset /* Kingmaker.Visual.Particles.SnapOffset */;
    public global::System.Collections.Generic.List<string> BonesNames /* System.Collections.Generic.List<System.String> */;
    public bool IgnoreSpecialBones /* System.Boolean */;

    public class SnapOffset {
        public bool Enabled /* System.Boolean */;
        public global::UnityEngine.AnimationCurve OffsetX /* UnityEngine.AnimationCurve */;
        public global::UnityEngine.AnimationCurve OffsetY /* UnityEngine.AnimationCurve */;
        public global::UnityEngine.AnimationCurve OffsetZ /* UnityEngine.AnimationCurve */;
        public bool UseWorldRotation /* System.Boolean */;
        public string WorldRotationBone /* System.String */;
    }

}

}

