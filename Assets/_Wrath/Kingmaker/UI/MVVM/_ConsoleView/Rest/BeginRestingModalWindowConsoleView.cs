using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Rest {

public class BeginRestingModalWindowConsoleView {
    [SerializeField] public object m_HeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HealingButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_HealingText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AutotuneButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_AutotuneText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BeginRestButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_BeginRestText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.BeginRestingDropdownConsoleView m_BeginRestingDropdownView /* Kingmaker.UI.MVVM._ConsoleView.Rest.BeginRestingDropdownConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestCorruptionProgressBarConsoleView m_CorruptionProgressBarView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestCorruptionProgressBarConsoleView */;
    [SerializeField] public global::UnityEngine.RectTransform m_HealingTooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_AutotuneTooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_BeginRestingDropdownTooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_CorruptionProgressBarTooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public object m_RestDeclineHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_TooltipHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_BeginRestButtonConfirmHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

