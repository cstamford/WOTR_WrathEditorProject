using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack {

public class SpellbookMagicHackMixerView {
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.MagicHackItemView m_ItemPrefab /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.MagicHackItemView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMixerSlotView m_Spell1 /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMixerSlotView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMixerSlotView m_Spell2 /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMixerSlotView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMixerSlotView m_SpellResult /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.Metamagic.SpellbookMixerSlotView */;
    [SerializeField] public object m_WriteSpellButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_WriteSpellButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClearSpellButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ClearSpellButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Slots /* Owlcat.Runtime.UI.Controls.Toggles.OwlcatToggleGroup */;
    [SerializeField] public object m_ResultName /* TMPro.TMP_InputField */;
    [SerializeField] public object m_SchoolsTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ThrowsTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TargetsTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_Schools /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_Throws /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_Targets /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerView.Icons m_Icons /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.Icons */;
    public object IsMagichackMixerOpen /* UniRx.ReactiveProperty */;

    public class Icons {
        [SerializeField] public object m_Schools /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SchoolIcon[] */;
        [SerializeField] public object m_Throws /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.ThrowIcon[] */;
        [SerializeField] public object m_Targets /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.TargetIcon[] */;

        public class SchoolIcon {
            public object School /* Kingmaker.Blueprints.Classes.Spells.SpellSchool */;
            public global::UnityEngine.Sprite Icon /* UnityEngine.Sprite */;
        }

        public class TargetIcon {
            public object Type /* Kingmaker.Blueprints.Classes.Spells.SpellTargetType */;
            public global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerView.Icons.IconPair Icon /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.IconPair */;
        }

        public class ThrowIcon {
            public object Type /* Kingmaker.EntitySystem.Stats.SavingThrowType */;
            public global::Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.SpellbookMagicHackMixerView.Icons.IconPair Icon /* Kingmaker.UI.MVVM._VM.ServiceWindows.Spellbook.MagicHack.IconPair */;
        }

        public struct IconPair {
            public global::UnityEngine.Sprite Enable /* UnityEngine.Sprite */;
            public global::UnityEngine.Sprite Disable /* UnityEngine.Sprite */;
        }

    }

}

}

