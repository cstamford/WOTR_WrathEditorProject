using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionLocoMotionHuman {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionLocoMotionHuman.WeaponStyleLayer> m_WeaponStyleOverrides /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.WeaponStyleLayer> */;
    public global::Kingmaker.Visual.Animation.AnimationClipWrapper NonCombatIdleWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    public object NonCombatWalkWrappers /* Kingmaker.Visual.Animation.AnimationClipWrapper[] */;
    public object NonCombatRacialWalkWrappers /* Kingmaker.Visual.Animation.Kingmaker.Actions.RacialWalks[] */;
    public global::UnityEngine.AvatarMask OffHandMask /* UnityEngine.AvatarMask */;

    public class RacialWalks {
        [SerializeField] public object m_Race /* Kingmaker.Blueprints.BlueprintRaceReference */;
        public object NonCombatWalks /* Kingmaker.Visual.Animation.AnimationClipWrapper[] */;
    }

    public class WeaponStyleLayer {
        public object Style /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public bool IsOffHand /* System.Boolean */;
        public bool NoOffHand /* System.Boolean */;
        public bool UseIK /* System.Boolean */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper IdleWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public object WalkWrappers /* Kingmaker.Visual.Animation.AnimationClipWrapper[] */;
    }

}

}

