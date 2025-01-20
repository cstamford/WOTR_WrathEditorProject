using Kingmaker.UI.MVVM._ConsoleView.Settings.Entities;
using Kingmaker.UI.MVVM._PCView.PhotoMode;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.PhotoMode {

public class PhotoModeConsoleView : global::Kingmaker.UI.MVVM._PCView.PhotoMode.PhotoModeBaseView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeConsoleView.PhotoModeSettingsConsoleViews m_PhotoModeSettingsViews /* Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeSettingsConsoleViews */;
    [SerializeField] public object m_HideUIHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_BackHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_PrevHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HUDHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_CameraHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_LeftBottomHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_RightBottomHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;

    public class PhotoModeSettingsConsoleViews {
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityHeaderConsoleView m_SettingsEntityHeaderViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityHeaderConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityBoolConsoleView m_SettingsEntityBoolViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityBoolConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityDropdownConsoleView m_SettingsEntityDropdownViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityDropdownConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView m_SettingsEntitySliderViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderVisualPerceptionConsoleView m_SettingsEntitySliderVisualPerceptionViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderVisualPerceptionConsoleView */;
    }

}

}

