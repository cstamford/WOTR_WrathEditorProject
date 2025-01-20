using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells {

public class CharGenSpellsPhaseDetailedPCView {
    [SerializeField] public object m_PhaseLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellsSelectorCheckPCView m_SpellsSelectorPCCheck /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellsSelectorCheckPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellbookPCView m_SpellbookView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellbookPCView */;
    [SerializeField] public object m_AvailableSpells /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SpellsSelectable /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeTransform /* UnityEngine.RectTransform */;
}

}

