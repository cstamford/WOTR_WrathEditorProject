using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race {

public class CharGenRacePhaseDetailedPCView {
    [SerializeField] public object m_RaceHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race.CharGenRaceSelectorPCView m_RaceSelectorPCView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race.CharGenRaceSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race.CharGenGenderSelectorPCView m_GenderSelectorPCView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race.CharGenGenderSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_DollRoom /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeInfoDollTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeInfoTransform /* UnityEngine.RectTransform */;
}

}

