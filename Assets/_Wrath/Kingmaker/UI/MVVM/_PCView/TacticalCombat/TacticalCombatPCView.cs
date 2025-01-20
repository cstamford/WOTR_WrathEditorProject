using Kingmaker.UI.MVVM._PCView.CombatLog;
using Kingmaker.UI.MVVM._PCView.Inspect;
using Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar;
using Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker;
using Kingmaker.UI.MVVM._PCView.TacticalCombat.Result;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat {

public class TacticalCombatPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatAttackTooltipPCView m_AttackTooltipPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatAttackTooltipPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CombatLog.CombatLogPCView m_CombatLogPCView /* Kingmaker.UI.MVVM._PCView.CombatLog.CombatLogPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatManagerPCView m_TacticalCombatManagerPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatManagerPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerPCView m_TacticalCombatInitiativeTrackerPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.UnitCrusadeActionBarPCView m_UnitCrusadeActionBarPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.UnitCrusadeActionBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.LeaderCrusadeActionBarPCView m_LeaderCrusadeActionBarPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.LeaderCrusadeActionBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatLeaderPCView m_OwnLeaderPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatLeaderPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatHospitalProgressBarPCView m_HospitalProgressBarPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatHospitalProgressBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatLeaderPCView m_EnemyLeaderPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatLeaderPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultsPCView m_TacticalCombatResultsPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatFlowingMessageCreatorPCView TacticalCombatFlowingMessageCreatorPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatFlowingMessageCreatorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.LeaderCardPCView m_LeaderCardPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.LeaderCardPCView */;
    [SerializeField] public object m_FleeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_InspectMultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Inspect.InspectPCView m_InspectPCView /* Kingmaker.UI.MVVM._PCView.Inspect.InspectPCView */;
    [SerializeField] public object m_AccelerateButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_AutoCombatButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
}

}

