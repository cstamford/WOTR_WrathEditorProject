using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Skills {

public class CharGenSkillsPhaseDetailedPCView {
    [SerializeField] public object m_PhaseLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MainLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SkillLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClassSkill /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RankLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ModifierLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MaxRankLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AvailiblePoints /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AvailiblePointsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PointsSelectable /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public global::UnityEngine.Transform m_StatAllocatorsContainer /* UnityEngine.Transform */;
    [SerializeField] public object m_MaxRankValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform TargetSizeTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
}

}

