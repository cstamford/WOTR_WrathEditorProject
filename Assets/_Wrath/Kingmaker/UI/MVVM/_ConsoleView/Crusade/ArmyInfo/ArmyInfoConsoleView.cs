using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo {

public class ArmyInfoConsoleView {
    [SerializeField] public object m_CreateArmyHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_RecruitHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_PrevMergeArmy /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextMergeArmy /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_MoveToMain /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_MoveToSecond /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmySquadSelectorConsoleView m_SquadSelector /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmySquadSelectorConsoleView */;
}

}

