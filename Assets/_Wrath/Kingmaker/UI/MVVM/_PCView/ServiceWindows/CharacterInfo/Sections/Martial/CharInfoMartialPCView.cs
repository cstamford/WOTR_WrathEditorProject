using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial {

public class CharInfoMartialPCView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView m_MainBabView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView m_MeleeBabView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView m_RangedBabView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView m_Initiative /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView m_SpellResistance /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverPCView m_CombatManeuver /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyPCView m_WeaponProficiency /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionPCView m_DamageReduction /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistancePCView m_EnergyResistance /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistancePCView */;
}

}

