using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Classes;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.RaceGenderAlignment;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Skills;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Total {

public class CharGenTotalPhaseDetailedConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitChanger /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints.CharInfoHitPointsPCView m_HitPointsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints.CharInfoHitPointsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.RaceGenderAlignment.CharInfoRaceGenderAlignmentConsoleView m_RaceGenderAlignment /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.RaceGenderAlignment.CharInfoRaceGenderAlignmentConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Classes.CharInfoClassesListConsoleView m_Classes /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Classes.CharInfoClassesListConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoAbilityScoresBlockConsoleView m_AbilityScores /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoAbilityScoresBlockConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Skills.CharInfoSkillsBlockConsoleView m_Skills /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Skills.CharInfoSkillsBlockConsoleView */;
    [SerializeField] public object m_AbilitiesLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoAbilitiesConsoleView m_AbilitiesView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoAbilitiesConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.CharInfoSpellTableListConsoleView m_SpellsTable /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.CharInfoSpellTableListConsoleView */;
    [SerializeField] public object m_AttackLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView m_MainBAB /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView m_MeleeBAB /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView m_RangedBAB /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverConsoleView m_CombatManeuver /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView m_Initiative /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView m_SpellResistance /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView */;
    [SerializeField] public object m_DefenseLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoArmorClassConsoleView m_ArmorClass /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoArmorClassConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoSavingThrowConsoleView m_SavingThrow /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoSavingThrowConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView m_Speed /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView */;
    [SerializeField] public object m_MartialLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyConsoleView m_WeaponProficiency /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionConsoleView m_DamageReduction /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistanceConsoleView m_EnergyResistance /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistanceConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_MartialScroll /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

