using Kingmaker.UI.MVVM._PCView.Tooltip.Bricks;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Tooltip.Bricks {

public class TooltipBrickTextConsoleView : global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTextView {
    [SerializeField] public object m_MultiButtonFirstFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MultiButtonSecondFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_NavigationParameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
}

}

