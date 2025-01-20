using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Experience;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Characteristics;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Information;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.KnownSpells;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.MemorizingPanel;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers;
using Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook {

public class SpellbookPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView NameAndPortraitPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Experience.CharInfoExperiencePCView m_ExperienceView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Experience.CharInfoExperiencePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers.SpellbookSwitcherPCView m_SpellbookSwitcherView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers.SpellbookSwitcherPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Characteristics.SpellbookCharacteristicsPCView m_CharacteristicsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Characteristics.SpellbookCharacteristicsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers.SpellbookLevelSwitcherPCView m_LevelSwitcherView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Switchers.SpellbookLevelSwitcherPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Information.SpellbookInformationPCView m_InformationView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Information.SpellbookInformationPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.KnownSpells.SpellbookKnownSpellsPCView m_KnownSpellsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.KnownSpells.SpellbookKnownSpellsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.MemorizingPanel.SpellbookMemorizingPanelPCView m_MemorizingPanelView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.MemorizingPanel.SpellbookMemorizingPanelPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMetamagicMixerPCView m_MetamagicMixerView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMetamagicMixerPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerPCView m_MagicHackMixerView /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerPCView */;
    [SerializeField] public object m_MetamagicButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_MetamagicLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MagicHackButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_MagicHackLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_NoSpellbooksContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MemorizingPanelContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MetamagicContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MagicHackContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_NoSpellbooksLabel /* TMPro.TextMeshProUGUI */;
}

}

