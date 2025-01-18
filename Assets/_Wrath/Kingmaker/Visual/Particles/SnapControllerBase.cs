using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class SnapControllerBase : MonoBehaviour {
    [SerializeField] public SnapControllerBase m_RotatableCopy /* Kingmaker.Visual.Particles.SnapControllerBase */;
    [SerializeField] public bool m_IsRotatableCopy /* System.Boolean */;
    public object SnapType /* Kingmaker.Visual.Particles.ParticleSnapType */;
    public SnapMapBase Map /* Kingmaker.Visual.Particles.SnapMapBase */;
    public bool SupressMapOverride /* System.Boolean */;
    public AnimationCurve CameraOffsetScale /* UnityEngine.AnimationCurve */;
    public bool ApplySizeScale /* System.Boolean */;
    public bool ApplyLifetimeScale /* System.Boolean */;
    public bool ApplyRateOverTimeScale /* System.Boolean */;
    public bool ApplyBurstScale /* System.Boolean */;
    public bool PersistWhenDisabled /* System.Boolean */;
    public SnapControllerBase.SnapOffset Offset /* Kingmaker.Visual.Particles.SnapOffset */;
    public List<string> BonesNames /* System.Collections.Generic.List<System.String> */;
    public bool IgnoreSpecialBones /* System.Boolean */;

    public class SnapOffset {
        public bool Enabled /* System.Boolean */;
        public AnimationCurve OffsetX /* UnityEngine.AnimationCurve */;
        public AnimationCurve OffsetY /* UnityEngine.AnimationCurve */;
        public AnimationCurve OffsetZ /* UnityEngine.AnimationCurve */;
        public bool UseWorldRotation /* System.Boolean */;
        public string WorldRotationBone /* System.String */;
    }

}

}

