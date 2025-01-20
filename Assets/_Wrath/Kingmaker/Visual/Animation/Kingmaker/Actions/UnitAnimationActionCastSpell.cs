using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionCastSpell {
    public float PrecastSpeedup /* System.Single */;
    public float CastSpeedup /* System.Single */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionCastSpell.AnimationStyleEntry> Animations /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.AnimationStyleEntry> */;
    [SerializeField] public global::Kingmaker.Visual.Animation.RuntimeAnimatorControllerWrapper m_AnimatorControllerWrapper /* Kingmaker.Visual.Animation.RuntimeAnimatorControllerWrapper */;
    [SerializeField] public float CastTimeFraction /* System.Single */;

    public enum CastAnimationStyle {
        SelfTouch = 0,
        Touch = 1,
        Point = 2,
        Directional = 3,
        Omni = 4,
        Self = 5,
        Thrown = 6,
        Potion = 7,
        Special = 8,
        Immediate = 9,
        EnchantWeapon = 10,
        BreathWeapon = 11,
        Kineticist = 12,
        CoupDeGrace = 13,
        MagicHack = 14,
    }

    public class AnimationEntry {
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper PrecastStartWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public float BlendToLoopedTime /* System.Single */;
        public float PrecastStartDuration /* System.Single */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper PrecastLoopedWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public float BlendToCastTime /* System.Single */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper CastClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public float PrecastSpeedup /* System.Single */;
        public float CastSpeedup /* System.Single */;
    }

    public class AnimationEntryWeaponOverride : global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionCastSpell.AnimationEntry {
        public object Weapon /* Kingmaker.View.Animation.WeaponAnimationStyle */;
    }

    public class AnimationStyleEntry {
        public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionCastSpell.CastAnimationStyle Style /* Kingmaker.Visual.Animation.Kingmaker.Actions.CastAnimationStyle */;
        public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionCastSpell.AnimationEntry Default /* Kingmaker.Visual.Animation.Kingmaker.Actions.AnimationEntry */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionCastSpell.AnimationEntryWeaponOverride> Overrides /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.AnimationEntryWeaponOverride> */;
    }

}

}

