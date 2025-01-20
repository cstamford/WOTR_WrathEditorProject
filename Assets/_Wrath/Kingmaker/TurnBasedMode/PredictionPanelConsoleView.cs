using Kingmaker.UI.MVVM._ConsoleView.InGame;
using Kingmaker.UI.TurnBasedMode;
using System;
using UnityEngine;

namespace Kingmaker.TurnBasedMode {

public class PredictionPanelConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.InGame.InGameConsoleView m_InGameConsoleView /* Kingmaker.UI.MVVM._ConsoleView.InGame.InGameConsoleView */;
    [SerializeField] public object m_ChangeSmartActionHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ChangeAction /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

