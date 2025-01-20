using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionDodge {
    [SerializeField] public object m_Settings /* Kingmaker.Visual.Animation.Kingmaker.Actions.WeaponStyleSettings[] */;

    public class WeaponStyleSettings {
        public object Style /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    }

}

}

