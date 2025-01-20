using Kingmaker.UI.MVVM._PCView.InfoWindow;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic {

public class SpellbookMetamagicMixerConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_LeftInfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_RightInfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic.SpellbookDecoratorConsoleView m_SpellbookDecoratorView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic.SpellbookDecoratorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic.SpellbookMetamagicSelectorConsoleView m_SpellbookMetamagicSelectorView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic.SpellbookMetamagicSelectorConsoleView */;
    [SerializeField] public object m_DeclineHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_WriteSpellHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SwitchInformationHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SelectMetamagicHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_UnSelectMetamagicHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SelectColorHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SelectBorderHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    public object IsMetamagicMixerOpen /* UniRx.BoolReactiveProperty */;
}

}

