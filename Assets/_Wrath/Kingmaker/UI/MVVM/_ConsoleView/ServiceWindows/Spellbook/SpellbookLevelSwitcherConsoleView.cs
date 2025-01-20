using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook {

public class SpellbookLevelSwitcherConsoleView {
    [SerializeField] public object m_PreviousFilterHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextFilterHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    public object CurrentSelectedLevelIsMetamagic /* UniRx.BoolReactiveProperty */;
}

}

