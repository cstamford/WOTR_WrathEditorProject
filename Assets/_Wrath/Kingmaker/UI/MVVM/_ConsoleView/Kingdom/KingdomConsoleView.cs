using Kingmaker.UI.GlobalMap;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.Armies;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.CombatResult;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.LeaderLevelUp;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.Overtips;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.PointerMarker;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit;
using Kingmaker.UI.MVVM._ConsoleView.GameOver;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Buffs;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Movement;
using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events;
using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Map;
using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Navigation;
using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements;
using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Toolbar;
using Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result;
using Kingmaker.UI.MVVM._ConsoleView.TargetSelection;
using Kingmaker.UI.MVVM._PCView.Crusade.Armies;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom {

public class KingdomConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Navigation.KingdomNavigationConsoleView m_NavigationConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Navigation.KingdomNavigationConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsBarConsoleView m_EventsBarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Map.KingdomMapConsoleView m_MapConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Map.KingdomMapConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements.KingdomSettlementsConsoleView m_SettlementsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements.KingdomSettlementsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Toolbar.KingdomToolbarConsoleView m_ToolbarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Toolbar.KingdomToolbarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView m_WorldWoundMiniConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView m_KenabresMiniConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.MiniMap.GlobalMapMiniConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomInfoConsoleView m_KingdomInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Buffs.GlobalMapKingdomBuffsConsoleView m_BuffsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Buffs.GlobalMapKingdomBuffsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Armies.GlobalMapCrusadeArmiesCardsConsoleView m_ArmiesCardsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Armies.GlobalMapCrusadeArmiesCardsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView m_ArmiesView /* Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar.GlobalMapActionBarConsoleView m_ActionBarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar.GlobalMapActionBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoHUDConsoleView m_ArmyInfoHUDConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoHUDConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoConsoleView m_ArmyInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyCartBuyLeaderConsoleView m_BuyLeaderConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyCartBuyLeaderConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit.RecruitConsoleView m_RecruitConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit.RecruitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.LeaderLevelUp.LeaderLevelUpConsoleView m_LevelUpConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.LeaderLevelUp.LeaderLevelUpConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TargetSelection.TargetSelectionGlobalMapConsoleView m_TargetSelectionConsoleView /* Kingmaker.UI.MVVM._ConsoleView.TargetSelection.TargetSelectionGlobalMapConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Movement.GlobalMapMovementConsoleView m_MovementConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Movement.GlobalMapMovementConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message.GlobalMapEnterMessageConsoleView m_EnterMessageConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.Message.GlobalMapEnterMessageConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.CombatResult.CombatResultConsoleView m_CombatResultConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.CombatResult.CombatResultConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result.TacticalCombatResultsConsoleView m_AutoCombatResultsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result.TacticalCombatResultsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Overtips.GlobalMapArmyOvertipsConsoleView m_OvertipsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Overtips.GlobalMapArmyOvertipsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerConsoleView m_PointerMarkerConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GameOver.GameOverConsoleView m_GameOverConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GameOver.GameOverConsoleView */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_ArmyHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
    public global::Kingmaker.UI.GlobalMap.NavigationArrowsController CompassPrefab /* Kingmaker.UI.GlobalMap.NavigationArrowsController */;
    public global::UnityEngine.Transform CompassContainer /* UnityEngine.Transform */;
}

}

