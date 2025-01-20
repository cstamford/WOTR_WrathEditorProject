using Kingmaker.UI.GlobalMap;
using Kingmaker.UI.MVVM._ConsoleView.CharGen;
using Kingmaker.UI.MVVM._ConsoleView.CombatLog;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.Armies;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.CombatResult;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.LeaderLevelUp;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.Overtips;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.PointerMarker;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit;
using Kingmaker.UI.MVVM._ConsoleView.Dialog;
using Kingmaker.UI.MVVM._ConsoleView.GameOver;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Buffs;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Movement;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Toolbar;
using Kingmaker.UI.MVVM._ConsoleView.GroupChanger;
using Kingmaker.UI.MVVM._ConsoleView.IngameMenu;
using Kingmaker.UI.MVVM._ConsoleView.Party;
using Kingmaker.UI.MVVM._ConsoleView.Rest;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows;
using Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result;
using Kingmaker.UI.MVVM._ConsoleView.TargetSelection;
using Kingmaker.UI.MVVM._ConsoleView.Teleport;
using Kingmaker.UI.MVVM._ConsoleView.Transition;
using Kingmaker.UI.MVVM._PCView.Crusade.Armies;
using Kingmaker.UI.MVVM._PCView.GlobalMap;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.GlobalMap {

public class GlobalMapConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.ServiceWindowsConsoleView m_ServiceWindowsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.ServiceWindowsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dialog.DialogContextConsoleView m_DialogContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Dialog.DialogContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenContextConsoleView m_CharGenContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GroupChanger.GroupChangerContextConsoleView m_GroupChangerContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GroupChanger.GroupChangerContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Toolbar.GlobalMapToolbarConsoleView m_ToolbarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Toolbar.GlobalMapToolbarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView m_WorldWoundMiniConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView m_KenabresMiniConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomInfoConsoleView m_KingdomInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Buffs.GlobalMapKingdomBuffsConsoleView m_BuffsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Buffs.GlobalMapKingdomBuffsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Party.PartyConsoleView m_PartyConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Party.PartyConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Party.PartyCardsConsoleView m_PartyCardsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Party.PartyCardsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.IngameMenu.IngameMenuCardsConsoleView m_IngameMenuCartConsoleView /* Kingmaker.UI.MVVM._ConsoleView.IngameMenu.IngameMenuCardsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Armies.GlobalMapCrusadeArmiesCardsConsoleView m_ArmiesCardsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Armies.GlobalMapCrusadeArmiesCardsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar.GlobalMapActionBarConsoleView m_ActionBarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar.GlobalMapActionBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView m_ArmiesView /* Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoConsoleView m_ArmyInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestConsoleView m_RestConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyCartBuyLeaderConsoleView m_BuyLeaderConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyCartBuyLeaderConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionConsoleView m_TransitionConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit.RecruitConsoleView m_RecruitConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit.RecruitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.LeaderLevelUp.LeaderLevelUpConsoleView m_LevelUpConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.LeaderLevelUp.LeaderLevelUpConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoHUDConsoleView m_ArmyInfoHUDConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoHUDConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TargetSelection.TargetSelectionGlobalMapConsoleView m_TargetSelectionConsoleView /* Kingmaker.UI.MVVM._ConsoleView.TargetSelection.TargetSelectionGlobalMapConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Movement.GlobalMapMovementConsoleView m_MovementConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Movement.GlobalMapMovementConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message.GlobalMapEnterMessageConsoleView m_EnterMessageConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message.GlobalMapEnterMessageConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message.GlobalMapRandomEncounterConsoleView m_RandomEncounterConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message.GlobalMapRandomEncounterConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.CombatResult.CombatResultConsoleView m_CombatResultConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.CombatResult.CombatResultConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result.TacticalCombatResultsConsoleView m_AutoCombatResultsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result.TacticalCombatResultsConsoleView */;
    [SerializeField] public object m_PartyHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ArmyHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapArmyModeBackgroundView m_ArmyModeBackgroundView /* Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapArmyModeBackgroundView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Overtips.GlobalMapArmyOvertipsConsoleView m_OvertipsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Overtips.GlobalMapArmyOvertipsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerConsoleView m_PointerMarkerConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GameOver.GameOverConsoleView m_GameOverConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GameOver.GameOverConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Teleport.TeleportConsoleView m_TeleportConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Teleport.TeleportConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogConsoleView m_CombatLogConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogConsoleView */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
    public global::Kingmaker.UI.GlobalMap.NavigationArrowsController CompassPrefab /* Kingmaker.UI.GlobalMap.NavigationArrowsController */;
    public global::UnityEngine.Transform CompassContainer /* UnityEngine.Transform */;
}

}

