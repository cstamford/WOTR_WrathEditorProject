using Kingmaker.UI.BugReport;
using Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown;
using Kingmaker.UI.MVVM._ConsoleView.Common.InputField;
using Kingmaker.UI.MVVM._ConsoleView.Rest;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class BugReportWindow : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Header /* TMPro.TMP_Text */;
    [SerializeField] public object m_AspectHeader /* TMPro.TMP_Text */;
    [SerializeField] public object m_ContextHeader /* TMPro.TMP_Text */;
    [SerializeField] public object m_SendButton /* TMPro.TMP_Text */;
    [SerializeField] public object m_HintText /* TMPro.TMP_Text */;
    [SerializeField] public object m_SuggestionTogle /* TMPro.TMP_Text */;
    [SerializeField] public object m_NormalTogle /* TMPro.TMP_Text */;
    [SerializeField] public object m_CriticalTogle /* TMPro.TMP_Text */;
    [SerializeField] public object m_DescriptionHeader /* TMPro.TMP_Text */;
    [SerializeField] public object m_EmailHeader /* TMPro.TMP_Text */;
    [SerializeField] public object m_EmailDescription /* TMPro.TMP_Text */;
    [SerializeField] public object m_ButtomDescription /* TMPro.TMP_Text */;
    [SerializeField] public object m_PrivacyCheckBoxDescription /* TMPro.TMP_Text */;
    [SerializeField] public object m_DiscordHeader /* TMPro.TMP_Text */;
    [SerializeField] public object m_EmailUpdatesCheckBoxDescription /* TMPro.TMP_Text */;
    public object InputField /* TMPro.TMP_InputField */;
    public global::UnityEngine.GameObject EmailGroup /* UnityEngine.GameObject */;
    public object Email /* TMPro.TMP_InputField */;
    public object AdditionalContactsInputField /* TMPro.TMP_InputField */;
    public global::UnityEngine.GameObject AdditionalContactsGameObject /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.ToggleGroup ToggleGroup /* UnityEngine.UI.ToggleGroup */;
    public global::UnityEngine.UI.Toggle Normal /* UnityEngine.UI.Toggle */;
    public object Context /* TMPro.TMP_Dropdown */;
    public object Aspect /* TMPro.TMP_Dropdown */;
    public global::UnityEngine.GameObject AssigneeGO /* UnityEngine.GameObject */;
    public object AssigneeDropdown /* TMPro.TMP_Dropdown */;
    public global::UnityEngine.GameObject FixVersionGO /* UnityEngine.GameObject */;
    public object FixVersion /* TMPro.TMP_Dropdown */;
    public global::UnityEngine.UI.Toggle PrivacyToggle /* UnityEngine.UI.Toggle */;
    public global::UnityEngine.UI.Toggle MarketingMaterialsToggle /* UnityEngine.UI.Toggle */;
    public global::UnityEngine.GameObject MarketingMaterialsToggleGO /* UnityEngine.GameObject */;
    public global::UnityEngine.RectTransform InputFieldRectTransform /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform BackGroundInputRectTransform /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform IssueTypeRectTransform /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform BottomTextRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.BugReport.BugReportDuplicatesBaseView m_BugReportDuplicatesView /* Kingmaker.UI.BugReport.BugReportDuplicatesBaseView */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_LogInputToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public object m_LogInputTitle /* TMPro.TMP_Text */;
    [SerializeField] public object m_LogInputDesctiption /* TMPro.TMP_Text */;
    [SerializeField] public object m_OpenBugReportText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_FirstOpenBugReportHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SecondOpenBugReportHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_OpenDuplicatesListButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_CloseButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_ReportConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_DuplicatesListButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension m_ContextConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension m_AspectConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension m_FixVersionConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension m_AssigneeConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_EmailConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_DiscordConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_DescriptionConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_CriticalConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_NormalConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_MinorConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_KeyboardLoggingConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_PrivacyConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_MarketingConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_SendConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_DrawingHolder /* UnityEngine.GameObject */;
    [SerializeField] public object m_DrawingHolderCloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.ToggleWorkaround m_CriticalToggle /* Kingmaker.UI.ToggleWorkaround */;
    [SerializeField] public global::Kingmaker.UI.ToggleWorkaround m_MinorToggle /* Kingmaker.UI.ToggleWorkaround */;
    [SerializeField] public global::Kingmaker.UI.ToggleWorkaround m_KeyboardLoggingToggle /* Kingmaker.UI.ToggleWorkaround */;
    [SerializeField] public global::Kingmaker.UI.ToggleWorkaround m_PrivacyToggle /* Kingmaker.UI.ToggleWorkaround */;
}

}

