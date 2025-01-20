using Kingmaker.UI.MVVM._PCView.CharGen;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen {

public class CharGenConsoleView {
    [SerializeField] public object PhaseDetailedFactory /* Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenPhaseDetailedConsoleViewsFactory */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_ConfirmHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextPhaseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_DeclineHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_PreviousPhaseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
}

}

