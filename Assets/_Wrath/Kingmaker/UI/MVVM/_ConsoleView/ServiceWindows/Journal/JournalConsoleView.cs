using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Journal {

public class JournalConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Journal.JournalNavigationConsoleView m_Navigation /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Journal.JournalNavigationConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalQuestPCView m_Quest /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalQuestPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
}

}

