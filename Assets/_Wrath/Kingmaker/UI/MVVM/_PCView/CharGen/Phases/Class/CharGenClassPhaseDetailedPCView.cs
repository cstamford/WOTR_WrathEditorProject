using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class {

public class CharGenClassPhaseDetailedPCView {
    [SerializeField] public object m_SelectorHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassSelectorPCView ClassListSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_DollRoom /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
    [SerializeField] public global::UnityEngine.GameObject m_SwitchModeButtonContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_SwitchModeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_SwitchModeButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseDetailedShortModePCView m_ShortModePCView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseDetailedShortModePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseDetailedMechanicModePCView m_MechanicModePCView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseDetailedMechanicModePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseDetailedLevelupModePCView m_LevelupModePCView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseDetailedLevelupModePCView */;
}

}

