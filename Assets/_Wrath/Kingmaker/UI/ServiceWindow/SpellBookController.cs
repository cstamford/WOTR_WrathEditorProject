using Kingmaker.UI.Common;
using Kingmaker.UI.ServiceWindow.CharacterScreen;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookController {
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookCharacteristics m_Characteristicts /* Kingmaker.UI.ServiceWindow.SpellBookCharacteristics */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookView m_SpellBookView /* Kingmaker.UI.ServiceWindow.SpellBookView */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookMemorizingPanel m_MemorizingPanel /* Kingmaker.UI.ServiceWindow.SpellBookMemorizingPanel */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookLevelTabs m_LevelMemorizeSwitcher /* Kingmaker.UI.ServiceWindow.SpellBookLevelTabs */;
    [SerializeField] public object m_MetamagicSwitcherText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookMetamagicMixer m_SpellBookMetamagicMixer /* Kingmaker.UI.ServiceWindow.SpellBookMetamagicMixer */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookSpellDecorator m_SpellBookDecorator /* Kingmaker.UI.ServiceWindow.SpellBookSpellDecorator */;
    [SerializeField] public object m_CharName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSPortrait m_Portrait /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSPortrait */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSLevel m_Level /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSLevel */;
    [SerializeField] public global::UnityEngine.GameObject m_BookContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_NoBookTextContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_NoBookText /* TMPro.TextMeshProUGUI */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.Common.UISection> AnimatedSections /* System.Collections.Generic.List<Kingmaker.UI.Common.UISection> */;
    public bool HasSpellbooks /* System.Boolean */;
    public int CurrentMemorizeLevel /* System.Int32 */;
    public bool SetupProcess /* System.Boolean */;
}

}

