using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.Settings.Entities;
using Kingmaker.UI.MVVM._PCView.Settings.Entities.Decorative;
using Kingmaker.UI.MVVM._PCView.Settings.Entities.Difficulty;
using Kingmaker.UI.MVVM._PCView.Settings.Entities.Localization;
using Kingmaker.UI.MVVM._PCView.Settings.KeyBindSetupDialog;
using Kingmaker.UI.MVVM._PCView.Settings.Menu;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Settings {

public class SettingsPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.SettingsPCView.SettingsViews m_SettingsViews /* Kingmaker.UI.MVVM._PCView.Settings.SettingsViews */;
    [SerializeField] public object m_VirtualList /* Owlcat.Runtime.UI.VirtualListSystem.VirtualListVertical */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.SettingsDescriptionPCView m_DescriptionView /* Kingmaker.UI.MVVM._PCView.Settings.SettingsDescriptionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Menu.SettingsMenuSelectorPCView m_MenuSelector /* Kingmaker.UI.MVVM._PCView.Settings.Menu.SettingsMenuSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.KeyBindSetupDialog.KeyBindingSetupDialogPCView m_KeyBindingSetupDialogView /* Kingmaker.UI.MVVM._PCView.Settings.KeyBindSetupDialog.KeyBindingSetupDialogPCView */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DefaultButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DefaultText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CancelButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_CancelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ApplyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ApplyText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;

    public class SettingsViews {
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.Decorative.SettingsEntityHeaderView m_SettingsEntityHeaderViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.Decorative.SettingsEntityHeaderView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityBoolPCView m_SettingsEntityBoolViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityBoolPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityDropdownPCView m_SettingsEntityDropdownViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityDropdownPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPCView m_SettingsEntitySliderViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityDropdownDisplayModePCView m_SettingsEntityDropdownDisplayModeViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityDropdownDisplayModePCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.Difficulty.SettingsEntityDropdownGameDifficultyPCView m_SettingsEntityDropdownGameDifficultyViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.Difficulty.SettingsEntityDropdownGameDifficultyPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderVisualPerceptionPCView m_SettingsEntitySliderVisualPerceptionViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderVisualPerceptionPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderVisualPerceptionWithImagesPCView m_SettingsEntitySliderVisualPerceptionWithImagesViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderVisualPerceptionWithImagesPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityStatisticsOptOutPCView m_SettingsEntityStatisticsOptOutViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityStatisticsOptOutPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingEntityKeyBindingPCView m_SettingEntityKeyBindingViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingEntityKeyBindingPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.Localization.SettingsEntityDropdownLocalizationPCView m_SettingsEntityDropdownLocalizationViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.Localization.SettingsEntityDropdownLocalizationPCView */;
    }

}

}

