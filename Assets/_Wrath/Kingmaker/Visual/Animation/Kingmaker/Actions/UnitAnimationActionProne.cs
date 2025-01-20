using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionProne {
    public bool AllowFallingBelowGround /* System.Boolean */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_FallingWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_FallingConsciousWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_DyingWhileProneWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public float m_TransitionToLyingTime /* System.Single */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_DeadWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_UnconsciousWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_SleepingWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_SleepingInCampInfo /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_TrippedWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
}

}

