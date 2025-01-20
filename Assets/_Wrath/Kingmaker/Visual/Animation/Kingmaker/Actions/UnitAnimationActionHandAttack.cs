using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionHandAttack {
    [SerializeField] public bool m_IsMainHand /* System.Boolean */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionHandAttack.WeaponStyleSettings> m_Settings /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.WeaponStyleSettings> */;

    public class WeaponStyleSettings {
        public object Style /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.AnimationClipWrapper> VariantWrappers /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationClipWrapper> */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper RendWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ChargeWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.AnimationClipWrapper> MountedVariantWrappers /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationClipWrapper> */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper MountedRendWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper MountedChargeWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    }

}

}

