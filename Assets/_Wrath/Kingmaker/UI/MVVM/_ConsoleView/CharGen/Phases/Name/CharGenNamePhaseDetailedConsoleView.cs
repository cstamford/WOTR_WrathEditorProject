using Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._ConsoleView.Common.InputField;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Name {

public class CharGenNamePhaseDetailedConsoleView {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BirthdayHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MonthHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DayHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SequentialSelectorConsoleView m_MonthSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SequentialSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SequentialSelectorConsoleView m_DaySelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SequentialSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_NamePartView /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
}

}

