using Kingmaker.UI.Common;
using Kingmaker.UI.ServiceWindow;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharacterScreenController {
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSScores AbilityScores /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSScores */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSLevel Level /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSLevel */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSPortrait HalfPortrait /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSPortrait */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSPortrait FullPortrait /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSPortrait */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAttack MainAttack /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAttack */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSDefense MainDefense /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSDefense */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAlignment Alignment /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAlignment */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAlignmentHistory AlignmentHistory /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAlignmentHistory */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAlignmentHistory AlignmentHistoryBiography /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAlignmentHistory */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSSkills Skills /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSSkills */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSBuffsAndConditions BuffsAndConditions /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSBuffsAndConditions */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAbilities Abilities /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAbilities */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSMartial Martial /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSMartial */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAttack AttackInMartial /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSAttack */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSClassTree ClassTree /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSClassTree */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSStories Stories /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSStories */;
    public global::Kingmaker.UI.ServiceWindow.Inventory Inventory /* Kingmaker.UI.ServiceWindow.Inventory */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.Common.UISection> AnimatedSections /* System.Collections.Generic.List<Kingmaker.UI.Common.UISection> */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSMenuToggle> m_CharscreenMenuButtons /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.CharacterScreen.CharSMenuToggle> */;
    public object CharName /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.Transform Menu /* UnityEngine.Transform */;
    public bool m_OpeningInitialized /* System.Boolean */;
    public global::UnityEngine.UI.ColorBlock ButtonDisableColorBlock /* UnityEngine.UI.ColorBlock */;
}

}

