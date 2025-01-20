using Kingmaker.UI.MVVM._PCView.CharGen;
using Kingmaker.UI.MVVM._PCView.CombatLog;
using Kingmaker.UI.MVVM._PCView.Common.MessageModal;
using Kingmaker.UI.MVVM._PCView.Crusade.Armies;
using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._PCView.Crusade.CombatResult;
using Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp;
using Kingmaker.UI.MVVM._PCView.Crusade.Overtips;
using Kingmaker.UI.MVVM._PCView.Crusade.PointerMarker;
using Kingmaker.UI.MVVM._PCView.Crusade.Recruit;
using Kingmaker.UI.MVVM._PCView.Dialog;
using Kingmaker.UI.MVVM._PCView.GameOver;
using Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Buffs;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Menu;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Message;
using Kingmaker.UI.MVVM._PCView.GlobalMap.MiniMap;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Toolbar;
using Kingmaker.UI.MVVM._PCView.GroupChanger;
using Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo;
using Kingmaker.UI.MVVM._PCView.Party;
using Kingmaker.UI.MVVM._PCView.Rest;
using Kingmaker.UI.MVVM._PCView.ServiceWindows;
using Kingmaker.UI.MVVM._PCView.TacticalCombat.Result;
using Kingmaker.UI.MVVM._PCView.Teleport;
using Kingmaker.UI.MVVM._PCView.Transition;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.GlobalMap {

public class GlobalMapPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.ServiceWindowsPCView m_ServiceWindowsPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.ServiceWindowsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.DialogContextPCView m_DialogContextPCView /* Kingmaker.UI.MVVM._PCView.Dialog.DialogContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.CharGenContextPCView m_CharGenContextPCView /* Kingmaker.UI.MVVM._PCView.CharGen.CharGenContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GroupChanger.GroupChangerContextPCView m_GroupChangerContextPCView /* Kingmaker.UI.MVVM._PCView.GroupChanger.GroupChangerContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Overtips.GlobalMapArmyOvertipsPCView m_GlobalMapArmyOvertipsPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Overtips.GlobalMapArmyOvertipsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerPCView m_GlobalMapArmyPointerMarkerPCView /* Kingmaker.UI.MVVM._PCView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Toolbar.GlobalMapToolbarPCView m_GlobalMapToolbarPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Toolbar.GlobalMapToolbarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomInfoPCView m_KingdomInfoPCView /* Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomInfoPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.MiniMap.GlobalMapMiniPCView m_WorldWoundMiniPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.MiniMap.GlobalMapMiniPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.MiniMap.GlobalMapMiniPCView m_KenabresMiniPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.MiniMap.GlobalMapMiniPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.PartyPCView m_PartyPCView /* Kingmaker.UI.MVVM._PCView.Party.PartyPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.CombatResult.CombatResultPCView m_CombatResultPCView /* Kingmaker.UI.MVVM._PCView.Crusade.CombatResult.CombatResultPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyCartBuyLeaderPCView m_BuyLeaderPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyCartBuyLeaderPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitPCView m_RecruitPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Transition.TransitionPCView m_TransitionPCView /* Kingmaker.UI.MVVM._PCView.Transition.TransitionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoPCView m_ArmyInfoPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestPCView m_RestPCView /* Kingmaker.UI.MVVM._PCView.Rest.RestPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Buffs.GlobalMapKingdomBuffsPCView m_GlobalMapKingdomBuffsPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Buffs.GlobalMapKingdomBuffsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar.GlobalMapActionBarPCView m_GlobalMapActionBarPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar.GlobalMapActionBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GameOver.GameOverPCView m_GameOverPCView /* Kingmaker.UI.MVVM._PCView.GameOver.GameOverPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Menu.GlobalMapMenuPCView m_GlobalMapMenuPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Menu.GlobalMapMenuPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView m_ArmiesPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.MessageModal.SkipTimePCView m_SkipTimePCView /* Kingmaker.UI.MVVM._PCView.Common.MessageModal.SkipTimePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CombatLog.CombatLogPCView m_CombatLogPCView /* Kingmaker.UI.MVVM._PCView.CombatLog.CombatLogPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapArmyModeBackgroundView m_GlobalMapArmyModeBackgroundPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapArmyModeBackgroundView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoHUDPCView m_ArmyInfoHUDPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoHUDPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Message.GlobalMapEnterMessagePCView m_GlobalMapEnterMessagePCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Message.GlobalMapEnterMessagePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Message.GlobalMapRandomEncounterPCView m_GlobalMapRandomEncounterPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Message.GlobalMapRandomEncounterPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapMoveHelperPCView m_GlobalMapMoveHelperPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapMoveHelperPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp.LeaderLevelUpPCView m_LeaderLevelUpPCView /* Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp.LeaderLevelUpPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Teleport.TeleportPCView m_TeleportPCView /* Kingmaker.UI.MVVM._PCView.Teleport.TeleportPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultsPCView m_AutoCombatResultsPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultsPCView */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
}

}

