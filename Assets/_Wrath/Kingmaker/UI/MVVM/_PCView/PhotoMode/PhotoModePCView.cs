using Kingmaker.UI.MVVM._PCView.Settings.Entities;
using Kingmaker.UI.MVVM._PCView.Settings.Entities.Decorative;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.PhotoMode {

public class PhotoModePCView : global::Kingmaker.UI.MVVM._PCView.PhotoMode.PhotoModeBaseView {
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.PhotoMode.PhotoModePCView.PhotoModeSettingsPCViews m_PhotoModeSettingsViews /* Kingmaker.UI.MVVM._PCView.PhotoMode.PhotoModeSettingsPCViews */;
    [SerializeField] public object m_PrevButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_PrevButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NextButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CameraUpDownButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CameraUpDownLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HideGUILabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HideGUIButtonsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HideUILabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HideUIButtonsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_WASDLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_WASDButtons /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ZXCLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ZXCButtons /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_HotKeysBackground /* UnityEngine.GameObject */;

    public class PhotoModeSettingsPCViews {
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.Decorative.SettingsEntityHeaderView m_SettingsEntityHeaderViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.Decorative.SettingsEntityHeaderView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityBoolPCView m_SettingsEntityBoolViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityBoolPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityDropdownPCView m_SettingsEntityDropdownViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntityDropdownPCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPhotoModePCView m_SettingsEntitySliderViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPhotoModePCView */;
        [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderVisualPerceptionPhotoModePCView m_SettingsEntitySliderVisualPerceptionViewPrefab /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderVisualPerceptionPhotoModePCView */;
    }

}

}

