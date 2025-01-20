using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Menu;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentHistory;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentWheel;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.BuffsAndConditions;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Skills;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo {

public class CharacterInfoPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Menu.CharInfoMenuPCView m_CharInfoMenuView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Menu.CharInfoMenuPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView NameAndPortraitPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.CharInfoLevelClassScoresPCView m_LevelClassScoresView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.CharInfoLevelClassScoresPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockPCView m_AttacksBlockView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockPCView m_DefenceBlockView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Skills.CharInfoSkillsBlockPCView m_SkillsBlockView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Skills.CharInfoSkillsBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.BuffsAndConditions.CharInfoBuffsAndConditionsPCView m_BuffsAndConditionsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.BuffsAndConditions.CharInfoBuffsAndConditionsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoAbilitiesPCView m_AbilitiesView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoAbilitiesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CharInfoMartialPCView m_MartialView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.CharInfoMartialPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockPCView m_MartialAttacksBlockView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentWheel.CharInfoAlignmentWheelPCView m_AlignmentWheelView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentWheel.CharInfoAlignmentWheelPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentHistory.CharInfoAlignmentHistoryPCView m_AlignmentHistoryView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentHistory.CharInfoAlignmentHistoryPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoStoriesPCView m_StoriesView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoStoriesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView NameFullPortraitPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentHistory.CharInfoAlignmentHistoryPCView m_BiographyAlignmentHistoryView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Alignment.AlignmentHistory.CharInfoAlignmentHistoryPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoStoriesPCView m_BiographyStoriesView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoStoriesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.UnitProgressionPCView m_ProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.UnitProgressionPCView */;
}

}

