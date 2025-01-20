using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Alignment;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Alignment {

public class CharGenAlignmentPhaseDetailedConsoleView {
    [SerializeField] public object m_HeaderLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AlignmentLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_AlignmentBackground /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Alignment.CharGenAlignmentSelectorPCView AlignmentSelectorConsoleView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Alignment.CharGenAlignmentSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform TargetSizeTransform /* UnityEngine.RectTransform */;
}

}

