using Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown;
using Kingmaker.UI.MVVM._ConsoleView.Common.InputField;
using Kingmaker.UI.MVVM._ConsoleView.Rest;
using Owlcat.Runtime.UI.ConsoleTools.HintTool;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class BugReportWindow : MonoBehaviour {
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
    public GameObject EmailGroup /* UnityEngine.GameObject */;
    public object Email /* TMPro.TMP_InputField */;
    public object AdditionalContactsInputField /* TMPro.TMP_InputField */;
    public GameObject AdditionalContactsGameObject /* UnityEngine.GameObject */;
    public ToggleGroup ToggleGroup /* UnityEngine.UI.ToggleGroup */;
    public Toggle Normal /* UnityEngine.UI.Toggle */;
    public object Context /* TMPro.TMP_Dropdown */;
    public object Aspect /* TMPro.TMP_Dropdown */;
    public GameObject AssigneeGO /* UnityEngine.GameObject */;
    public object AssigneeDropdown /* TMPro.TMP_Dropdown */;
    public GameObject FixVersionGO /* UnityEngine.GameObject */;
    public object FixVersion /* TMPro.TMP_Dropdown */;
    public Toggle PrivacyToggle /* UnityEngine.UI.Toggle */;
    public Toggle MarketingMaterialsToggle /* UnityEngine.UI.Toggle */;
    public GameObject MarketingMaterialsToggleGO /* UnityEngine.GameObject */;
    public RectTransform InputFieldRectTransform /* UnityEngine.RectTransform */;
    public RectTransform BackGroundInputRectTransform /* UnityEngine.RectTransform */;
    public RectTransform IssueTypeRectTransform /* UnityEngine.RectTransform */;
    public RectTransform BottomTextRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public object m_BugReportDuplicatesView /* Kingmaker.UI.BugReport.BugReportDuplicatesBaseView */;
    [SerializeField] public Toggle m_LogInputToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public object m_LogInputTitle /* TMPro.TMP_Text */;
    [SerializeField] public object m_LogInputDesctiption /* TMPro.TMP_Text */;
    [SerializeField] public object m_OpenBugReportText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public ConsoleHint m_FirstOpenBugReportHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public ConsoleHint m_SecondOpenBugReportHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_OpenDuplicatesListButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public FloatButtonConsoleView m_CloseButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_ReportConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_DuplicatesListButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public DropdownConsoleExtension m_ContextConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public DropdownConsoleExtension m_AspectConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public DropdownConsoleExtension m_FixVersionConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public DropdownConsoleExtension m_AssigneeConsoleDropdown /* Kingmaker.UI.MVVM._ConsoleView.Common.Dropdown.DropdownConsoleExtension */;
    [SerializeField] public ConsoleInputField m_EmailConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public ConsoleInputField m_DiscordConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public ConsoleInputField m_DescriptionConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public FloatButtonConsoleView m_CriticalConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_NormalConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_MinorConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_KeyboardLoggingConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_PrivacyConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_MarketingConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public FloatButtonConsoleView m_SendConsoleButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public GameObject m_DrawingHolder /* UnityEngine.GameObject */;
    [SerializeField] public object m_DrawingHolderCloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_CriticalToggle /* Kingmaker.UI.ToggleWorkaround */;
    [SerializeField] public object m_MinorToggle /* Kingmaker.UI.ToggleWorkaround */;
    [SerializeField] public object m_KeyboardLoggingToggle /* Kingmaker.UI.ToggleWorkaround */;
    [SerializeField] public object m_PrivacyToggle /* Kingmaker.UI.ToggleWorkaround */;
}

}

