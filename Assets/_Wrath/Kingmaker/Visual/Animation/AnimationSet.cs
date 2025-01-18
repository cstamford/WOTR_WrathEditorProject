using Kingmaker.Visual.Animation.Actions;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class AnimationSet : ScriptableObject {
    [SerializeField] public AnimationActionBase m_StartupAction /* Kingmaker.Visual.Animation.Actions.AnimationActionBase */;
    [SerializeField] public List<AnimationActionBase> m_Actions /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Actions.AnimationActionBase> */;
    [SerializeField] public List<Transition> m_Transitions /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Transition> */;
    [SerializeField] public List<AnimationSet.AnimationSequence> m_Sequences /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationSequence> */;

    public class AnimationSequenceAction {
        [SerializeField] public object UnitAnimationType /* Kingmaker.Visual.Animation.Kingmaker.UnitAnimationType */;
        [SerializeField] public object UnitAnimationSpecialAttackType /* Kingmaker.Visual.Animation.Kingmaker.UnitAnimationSpecialAttackType */;
        [SerializeField] public object WeaponAnimationStyle /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        [SerializeField] public object AnimationClipWrapper /* Kingmaker.ResourceLinks.AnimationClipWrapperLink */;
    }

    public class AnimationSequence {
        [SerializeField] public List<AnimationSet.AnimationSequenceAction> Actions /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationSequenceAction> */;
        [SerializeField] public float Probability /* System.Single */;
    }

}

}

