using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Classes;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.RaceGenderAlignment;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Skills;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Total {

public class CharGenTotalPhaseDetailedPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitChanger /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints.CharInfoHitPointsPCView m_HitPointsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints.CharInfoHitPointsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.RaceGenderAlignment.CharInfoRaceGenderAlignmentPCView m_RaceGenderAlignment /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.RaceGenderAlignment.CharInfoRaceGenderAlignmentPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Classes.CharInfoClassesListPCView m_Classes /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Classes.CharInfoClassesListPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoAbilityScoresBlockPCView m_AbilityScores /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoAbilityScoresBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Skills.CharInfoSkillsBlockPCView m_Skills /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Skills.CharInfoSkillsBlockPCView */;
    [SerializeField] public object m_AbilitiesLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoAbilitiesPCView m_AbilitiesView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoAbilitiesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.CharInfoSpellTableListView m_SpellsTable /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.CharInfoSpellTableListView */;
    [SerializeField] public object m_AttackLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView m_MainBAB /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView m_MeleeBAB /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView m_RangedBAB /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverPCView m_CombatManeuver /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView m_Initiative /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView m_SpellResistance /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView */;
    [SerializeField] public object m_DefenseLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoArmorClassPCView m_ArmorClass /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoArmorClassPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoSavingThrowPCView m_SavingThrow /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoSavingThrowPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView m_Speed /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView */;
    [SerializeField] public object m_MartialLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyPCView m_WeaponProficiency /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionPCView m_DamageReduction /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistancePCView m_EnergyResistance /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistancePCView */;
}

}

