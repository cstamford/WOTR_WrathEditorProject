using Kingmaker.UI.MVVM._PCView.Crusade.Armies;
using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._PCView.Crusade.CombatResult;
using Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp;
using Kingmaker.UI.MVVM._PCView.Crusade.Overtips;
using Kingmaker.UI.MVVM._PCView.Crusade.PointerMarker;
using Kingmaker.UI.MVVM._PCView.Crusade.Recruit;
using Kingmaker.UI.MVVM._PCView.GameOver;
using Kingmaker.UI.MVVM._PCView.GlobalMap;
using Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Buffs;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Menu;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Message;
using Kingmaker.UI.MVVM._PCView.GlobalMap.Toolbar;
using Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo;
using Kingmaker.UI.MVVM._PCView.TacticalCombat.Result;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Kingdom {

public class KingdomPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Toolbar.GlobalMapToolbarPCView m_GlobalMapToolbarPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Toolbar.GlobalMapToolbarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomInfoPCView m_KingdomInfoPCView /* Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomInfoPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GameOver.GameOverPCView m_GameOverPCView /* Kingmaker.UI.MVVM._PCView.GameOver.GameOverPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Overtips.GlobalMapArmyOvertipsPCView m_GlobalMapArmyOvertipsPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Overtips.GlobalMapArmyOvertipsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerPCView m_GlobalMapArmyPointerMarkerPCView /* Kingmaker.UI.MVVM._PCView.Crusade.PointerMarker.GlobalMapArmyPointerMarkerPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.CombatResult.CombatResultPCView m_CombatResultPCView /* Kingmaker.UI.MVVM._PCView.Crusade.CombatResult.CombatResultPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyCartBuyLeaderPCView m_BuyLeaderPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyCartBuyLeaderPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitPCView m_RecruitPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoPCView m_ArmyInfoPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar.GlobalMapActionBarPCView m_GlobalMapActionBarPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar.GlobalMapActionBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoHUDPCView m_ArmyInfoHUDPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoHUDPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapMoveHelperPCView m_GlobalMapMoveHelperPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.GlobalMapMoveHelperPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Buffs.GlobalMapKingdomBuffsPCView m_GlobalMapKingdomBuffsPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Buffs.GlobalMapKingdomBuffsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp.LeaderLevelUpPCView m_LeaderLevelUpPCView /* Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp.LeaderLevelUpPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultsPCView m_AutoCombatResultsPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Menu.GlobalMapMenuPCView m_GlobalMapMenuPCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Menu.GlobalMapMenuPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView m_ArmiesPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Armies.GlobalMapCrusadeArmiesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.Message.GlobalMapEnterMessagePCView m_GlobalMapEnterMessagePCView /* Kingmaker.UI.MVVM._PCView.GlobalMap.Message.GlobalMapEnterMessagePCView */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
}

}

