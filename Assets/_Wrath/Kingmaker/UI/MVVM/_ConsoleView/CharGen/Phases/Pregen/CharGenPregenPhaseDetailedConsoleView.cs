using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Pregen;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Pregen {

public class CharGenPregenPhaseDetailedConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeInfoTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_DollRoom /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeDollRoomTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public object m_PregenHeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Pregen.CharGenPregenSelectorPCView PregenSelectorConsoleView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Pregen.CharGenPregenSelectorPCView */;
    [SerializeField] public object m_CreateCustomCharacterButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_CreateCustomCharacterButtonLabel /* TMPro.TextMeshProUGUI */;
}

}

