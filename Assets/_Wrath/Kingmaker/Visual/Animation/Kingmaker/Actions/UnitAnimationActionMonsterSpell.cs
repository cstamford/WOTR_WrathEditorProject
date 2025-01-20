using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionMonsterSpell {
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_CastClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public object Additional /* Kingmaker.Visual.Animation.Kingmaker.Actions.AdditionalClipData[] */;

    public class BlueprintAbilityLink {
        public string AssetId /* System.String */;
    }

    public class AdditionalClipData {
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionMonsterSpell.BlueprintAbilityLink> SpellsList /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Kingmaker.Actions.BlueprintAbilityLink> */;
    }

}

}

