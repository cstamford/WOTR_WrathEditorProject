using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Spells {

public class CharGenSpellsPhaseDetailedConsoleView {
    [SerializeField] public object m_PhaseLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellsSelectorCheckPCView m_SpellsSelectorConsoleCheck /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellsSelectorCheckPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Spells.CharGenSpellbookConsoleView m_SpellbookView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Spells.CharGenSpellbookConsoleView */;
    [SerializeField] public object m_AvailableSpells /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SpellsSelectable /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeTransform /* UnityEngine.RectTransform */;
}

}

