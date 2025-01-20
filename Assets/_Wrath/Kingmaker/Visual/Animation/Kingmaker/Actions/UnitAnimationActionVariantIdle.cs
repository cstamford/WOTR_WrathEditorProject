using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionVariantIdle {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.AnimationClipWrapper> m_ClipWrappers /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationClipWrapper> */;
    public object RetriggerProbability /* Kingmaker.Visual.Animation.Kingmaker.Actions.TimedProbabilityCurve */;
    public bool PlayOnNPC /* System.Boolean */;
    public object ClassOverrides /* Kingmaker.Visual.Animation.Kingmaker.Actions.ClassOverrideData[] */;
    public object RaceOverrides /* Kingmaker.Visual.Animation.Kingmaker.Actions.RaceOverrideData[] */;

    public class ClassOverrideData {
        [SerializeField] public object m_Class /* Kingmaker.Blueprints.BlueprintCharacterClassReference */;
        public float Chance /* System.Single */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.AnimationClipWrapper> ClipWrappers /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationClipWrapper> */;
    }

    public class RaceOverrideData {
        [SerializeField] public object m_Race /* Kingmaker.Blueprints.BlueprintRaceReference */;
        public float Chance /* System.Single */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.AnimationClipWrapper> ClipWrappers /* System.Collections.Generic.List<Kingmaker.Visual.Animation.AnimationClipWrapper> */;
    }

}

}

