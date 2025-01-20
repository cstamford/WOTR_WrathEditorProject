using Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._PCView.TacticalCombat;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat {

public class LeaderCardConsoleView : global::Kingmaker.UI.MVVM._PCView.TacticalCombat.LeaderCardBaseView {
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyLeaderSkillsConsoleView m_SkillsPCView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyLeaderSkillsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyLeaderStatsConsoleView m_StatsView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyLeaderStatsConsoleView */;
}

}

