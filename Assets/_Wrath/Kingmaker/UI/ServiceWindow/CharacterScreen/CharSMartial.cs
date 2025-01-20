using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSMartial : global::Kingmaker.UI.Common.UISection {
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSMartial.QualitiesLabels Labels /* Kingmaker.UI.ServiceWindow.CharacterScreen.QualitiesLabels */;
    public global::UnityEngine.GameObject BABElement /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform BABBox /* UnityEngine.Transform */;
    public global::UnityEngine.GameObject BABRangedElement /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform BABRangedBox /* UnityEngine.Transform */;
    public global::UnityEngine.GameObject BABMeleeElement /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform BABMeleeBox /* UnityEngine.Transform */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString CMB /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString CMD /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString Initiative /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString SpellResistance /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::UnityEngine.GameObject DRBlock /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform DREntries /* UnityEngine.Transform */;
    public global::UnityEngine.GameObject ERBlock /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform EREntries /* UnityEngine.Transform */;
    public global::UnityEngine.GameObject WeaponProficiecyBlock /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform WeaponProficiecyContainer /* UnityEngine.Transform */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentWProf WeaponProficiecyEntry /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentWProf */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentReductionEntry DR_ERPrefab /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentReductionEntry */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator CMLabelBG /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator CMBBG /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator CMDBG /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator InitiativeBG /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator MeleeBABBG /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator RangeBABBG /* Kingmaker.UI.Common.Animations.FadeAnimator */;

    public class QualitiesLabels {
        public object MainLabel /* TMPro.TextMeshProUGUI */;
        public object WeaponProficiency /* TMPro.TextMeshProUGUI */;
        public object BaseAttackBonus /* TMPro.TextMeshProUGUI */;
        public object BaseAttackBonusRanged /* TMPro.TextMeshProUGUI */;
        public object BaseAttackBonusMelee /* TMPro.TextMeshProUGUI */;
        public object CombatManeuver /* TMPro.TextMeshProUGUI */;
        public object Initiative /* TMPro.TextMeshProUGUI */;
        public object SpellResistance /* TMPro.TextMeshProUGUI */;
        public object DamageReduction /* TMPro.TextMeshProUGUI */;
        public object DamageReductionValue /* TMPro.TextMeshProUGUI */;
        public object DamageReductionExceptions /* TMPro.TextMeshProUGUI */;
        public object EnergyResistance /* TMPro.TextMeshProUGUI */;
        public object EnergyResistanceValue /* TMPro.TextMeshProUGUI */;
        public object EnergyResistanceInclusions /* TMPro.TextMeshProUGUI */;
    }

}

}

