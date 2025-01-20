using Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.AbilityScores {

public class CharGenAbilityScoresDetailedConsoleView {
    [SerializeField] public object m_PhaseLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ScoresLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ModifierLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RaceBonus /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AvailiblePoints /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AvailiblePointsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PointsSelectable /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public global::UnityEngine.Transform m_StatAllocatorsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject m_RaceBonusContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_RaceBonusLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SequentialSelectorConsoleView RaceBonusSelectorPc /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SequentialSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform TargetSizeTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
}

}

