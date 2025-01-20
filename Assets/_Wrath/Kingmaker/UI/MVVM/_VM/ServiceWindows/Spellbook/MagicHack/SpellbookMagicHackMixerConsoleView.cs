using Kingmaker.UI.MVVM._ConsoleView.ActionBar;
using Kingmaker.UI.MVVM._ConsoleView.Common.InputField;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack {

public class SpellbookMagicHackMixerConsoleView : global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_InputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ActionBar.ActionBarSelectorView m_Selector /* Kingmaker.UI.MVVM._ConsoleView.ActionBar.ActionBarSelectorView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_LeftInfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_RightInfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_WriteSpellHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_CancelHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_PrevSlotHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextSlotHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

