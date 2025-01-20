using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.Settings.Entities;
using Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.Difficulty;
using Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.Localization;
using Kingmaker.UI.MVVM._ConsoleView.Settings.Menu;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.Settings {

public class SettingsConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.SettingsConsoleView.SettingsViews m_SettingsViews /* Kingmaker.UI.MVVM._ConsoleView.Settings.SettingsViews */;
    [SerializeField] public object m_VirtualList /* Owlcat.Runtime.UI.VirtualListSystem.VirtualListVertical */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.SettingsDescriptionConsoleView m_DescriptionView /* Kingmaker.UI.MVVM._ConsoleView.Settings.SettingsDescriptionConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Menu.SettingsMenuSelectorConsoleView m_MenuSelector /* Kingmaker.UI.MVVM._ConsoleView.Settings.Menu.SettingsMenuSelectorConsoleView */;
    [SerializeField] public object m_PrevHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.UI.Image m_PenImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_ControlsConsoleGroup /* UnityEngine.GameObject */;

    public class SettingsViews {
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityHeaderConsoleView m_SettingsEntityHeaderViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityHeaderConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityBoolConsoleView m_SettingsEntityBoolViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityBoolConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityDropdownConsoleView m_SettingsEntityDropdownViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityDropdownConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView m_SettingsEntitySliderViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityDropdownDisplayModeConsoleView m_SettingsEntityDropdownDisplayModeViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityDropdownDisplayModeConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.Difficulty.SettingsEntityGameDifficultyConsoleView SettingsEntityGameDifficultyViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.Difficulty.SettingsEntityGameDifficultyConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderVisualPerceptionConsoleView m_SettingsEntitySliderVisualPerceptionViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderVisualPerceptionConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderVisualPerceptionWithImagesConsoleView m_SettingsEntitySliderVisualPerceptionWithImagesViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderVisualPerceptionWithImagesConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityStatisticsOptOutConsoleView m_SettingsEntityStatisticsOptOutViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntityStatisticsOptOutConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingEntityKeyBindingConsoleView m_SettingEntityKeyBindingViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingEntityKeyBindingConsoleView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.Localization.SettingsEntityDropdownLocalizationConsoleView m_SettingsEntityDropdownLocalizationViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.Localization.SettingsEntityDropdownLocalizationConsoleView */;
    }

}

}

