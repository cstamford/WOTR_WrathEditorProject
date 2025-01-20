using Kingmaker.UI.MVVM._PCView.Rest;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Rest {

public class RestCraftConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView m_PrimaryShiftView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView m_SecondaryShiftView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView */;
    [SerializeField] public object m_NavigationParameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_FocusPotionCraftMultiButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_FocusMagicBrothMultiButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestScrollScribingSkillSelectorConsoleView m_ScrollScribingSkillSelector /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestScrollScribingSkillSelectorConsoleView */;
    [SerializeField] public object m_PotionCraftConsoleHintConfirm /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_MagicBrothConsoleHintConfirm /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_PotionCraftText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MagicBrothText /* TMPro.TextMeshProUGUI */;
}

}

