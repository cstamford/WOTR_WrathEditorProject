using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionSpecialAttack {
    [SerializeField] public object m_AttackType /* Kingmaker.Visual.Animation.Kingmaker.UnitAnimationSpecialAttackType */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionSpecialAttack.Entry> m_Attacks /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.Entry> */;

    public class Entry {
        public object VariantWrappers /* Kingmaker.Visual.Animation.AnimationClipWrapper[] */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper RendWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ChargeWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public bool HasRangeBlend /* System.Boolean */;
        public float[] BlendRanges /* System.Single[] */;
    }

}

}

