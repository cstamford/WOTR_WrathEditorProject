using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionSequence {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionSequence.Entry> m_Clips /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.Entry> */;

    public class Entry {
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public float OverrideDuration /* System.Single */;
        public float SpeedCoeff /* System.Single */;
        public float BlendOutTime /* System.Single */;
    }

}

}

