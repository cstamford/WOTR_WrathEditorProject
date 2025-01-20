using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionInteract {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionInteract.Setting> m_Settings /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.Setting> */;

    public class Setting {
        public object Type /* Kingmaker.Visual.Animation.Kingmaker.UnitAnimationInteractionType */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    }

}

}

