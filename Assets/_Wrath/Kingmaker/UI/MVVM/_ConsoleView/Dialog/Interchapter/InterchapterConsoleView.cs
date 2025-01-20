using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.Dialog.Interchapter;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Dialog.Interchapter {

public class InterchapterConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_NavigationParameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
    [SerializeField] public object m_FirstGlossaryFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_SecondGlossaryFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

