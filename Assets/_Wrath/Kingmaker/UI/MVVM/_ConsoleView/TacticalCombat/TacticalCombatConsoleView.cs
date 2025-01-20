using Kingmaker.UI.MVVM._ConsoleView.CombatLog;
using Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker;
using Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result;
using Kingmaker.UI.MVVM._PCView.TacticalCombat;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat {

public class TacticalCombatConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatAttackTooltipPCView m_AttackTooltipPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatAttackTooltipPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatFlowingMessageCreatorPCView m_TacticalCombatFlowingMessageCreatorPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatFlowingMessageCreatorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatManagerPCView m_TacticalCombatManagerPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatManagerPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.LeaderCardConsoleView m_LeaderCardPCView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.LeaderCardConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatLeaderConsoleView m_OwnLeaderPCView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatLeaderConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatHospitalProgressBarPCView m_HospitalProgressBarPCView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.TacticalCombatHospitalProgressBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatLeaderConsoleView m_EnemyLeaderPCView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatLeaderConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatLeaderActionBarConsoleView m_LeaderActionBarView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatLeaderActionBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatUnitActionBarConsoleView m_UnitActionBarView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.TacticalCombatUnitActionBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result.TacticalCombatResultsConsoleView m_TacticalCombatResultsView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.Result.TacticalCombatResultsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogConsoleView m_CombatLogPCView /* Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerConsoleView m_TacticalCombatInitiativeTrackerPCView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerConsoleView */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_ChangeActiveStateCombatLogHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ShowTrackerTooltipHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ShowLeaderCard /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ShowEnemyLeaderCard /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_LeaderActionBarHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_UnitActionBarHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HoldHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_DefenseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_FleeHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_FleeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_AccelerationHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_AccelerationButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_AutoCombatHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_AutoCombatButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
}

}

