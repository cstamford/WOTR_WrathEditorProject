using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionMicroIdle {
    public object TriggerProbability /* Kingmaker.Visual.Animation.Kingmaker.Actions.TimedProbabilityCurve */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionMicroIdle.ClipList> Variants /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.ClipList> */;
    public object OffHandAnimations /* Kingmaker.Visual.Animation.Kingmaker.Actions.MaskedClipList[] */;

    public class ClipList {
        public object Weapon /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public bool IsOffHand /* System.Boolean */;
        public object ClipWrappers /* Kingmaker.Visual.Animation.AnimationClipWrapper[] */;
    }

    public class MaskedClipList {
        public object MainWeapon /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public object OffWeapon /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public global::UnityEngine.AvatarMask Mask /* UnityEngine.AvatarMask */;
        public object ClipWrappers /* Kingmaker.Visual.Animation.AnimationClipWrapper[] */;
    }

}

}

