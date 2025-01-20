using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers;
using Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook {

public class SpellbookConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitConsoleView m_NameAndPortraitView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers.SpellbookSwitcherPCView m_SpellbookSwitcherView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers.SpellbookSwitcherPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookCharacteristicsConsoleView m_CharacteristicsView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookCharacteristicsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookLevelSwitcherConsoleView m_LevelSwitcherView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookLevelSwitcherConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookInformationConsoleView m_InformationView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookInformationConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookKnownSpellsConsoleView m_KnownSpellsView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookKnownSpellsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookMemorizingPanelConsoleView m_MemorizingPanelView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookMemorizingPanelConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic.SpellbookMetamagicMixerConsoleView m_MetamagicMixerView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic.SpellbookMetamagicMixerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerConsoleView m_MagichackMixerView /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerConsoleView */;
    [SerializeField] public object m_MetamagicLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_NoSpellbooksContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MemorizingPanelContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_NoSpellbooksLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MetamagicContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MagichackContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_ConfirmHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_DeclineHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SwitchBookHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_MetamagicHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_MagichackHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ShowAllSpellsHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ForgetHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ContextMenuHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ExpandHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_BackHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintWithAutoLayout */;
    [SerializeField] public object m_NextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintWithAutoLayout */;
    [SerializeField] public object m_PartyHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintWithAutoLayout */;
    [SerializeField] public object m_MenuHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintWithAutoLayout */;
    [SerializeField] public object m_Parameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
}

}

