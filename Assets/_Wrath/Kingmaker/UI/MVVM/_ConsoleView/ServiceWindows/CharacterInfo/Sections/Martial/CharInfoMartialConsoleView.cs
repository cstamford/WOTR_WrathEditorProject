using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial {

public class CharInfoMartialConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainFadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockConsoleView m_DefenceBlockView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockConsoleView */;
    [SerializeField] public object m_MainLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView m_MainBabView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView m_MeleeBabView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView m_RangedBabView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.BAB.CharInfoBABConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView m_Initiative /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView m_SpellResistance /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.AbilityScores.CharInfoStatConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverConsoleView m_CombatManeuver /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.CombatManeuver.CharInfoCombatManeuverConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyConsoleView m_WeaponProficiency /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionConsoleView m_DamageReduction /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.DamageReduction.CharInfoDamageReductionConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistanceConsoleView m_EnergyResistance /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistanceConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

