using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia {

public class EncyclopediaConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia.EncyclopediaNavigationConsoleView m_Navigation /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia.EncyclopediaNavigationConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia.EncyclopediaPageConsoleView m_Page /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia.EncyclopediaPageConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_PrevHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasPrevHint /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasNextHint /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_NavigationParameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
    [SerializeField] public object m_FirstGlossaryFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_SecondGlossaryFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    public object CanExpand /* UniRx.BoolReactiveProperty */;
    public object CanCollapse /* UniRx.BoolReactiveProperty */;
}

}

