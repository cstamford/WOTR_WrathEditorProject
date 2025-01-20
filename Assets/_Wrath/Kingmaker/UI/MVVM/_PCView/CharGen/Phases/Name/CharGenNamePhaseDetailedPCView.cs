using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Name {

public class CharGenNamePhaseDetailedPCView {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NameInputField /* TMPro.TMP_InputField */;
    [SerializeField] public object m_NameInputFieldPlaceholder /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_GenerateButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_BirthdayHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MonthHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DayHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SequentialSelectorPCView MonthSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SequentialSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SequentialSelectorPCView DaySelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SequentialSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
}

}

