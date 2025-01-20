using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.TargetSelection;
using Kingmaker.UI.MVVM._PCView.GlobalMap.ActionBar;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.GlobalMap.ActionBar {

public class GlobalMapActionBarConsoleView {
    [SerializeField] public object m_SpellName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_SpellNameContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_HintOpen /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintClose /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintInformation /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TargetSelection.TargetSelectionGlobalMapConsoleView m_TargetSelection /* Kingmaker.UI.MVVM._ConsoleView.TargetSelection.TargetSelectionGlobalMapConsoleView */;
}

}

