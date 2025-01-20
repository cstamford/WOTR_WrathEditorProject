using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionStun {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionStun.AnimationEntry> m_Animations /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.AnimationEntry> */;

    public class AnimationEntry {
        [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper StunnedLoopWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper ExitStunWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        [SerializeField] public object Style /* Kingmaker.View.Animation.WeaponAnimationStyle */;
    }

}

}

