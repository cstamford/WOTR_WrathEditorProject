using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo {

public class ArmyInfoHUDConsoleView {
    [SerializeField] public object m_HintInfo /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintOpen /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintClose /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmySquadSelectorConsoleView m_SquadSelector /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmySquadSelectorConsoleView */;
    public object IsActive /* UniRx.BoolReactiveProperty */;
}

}

