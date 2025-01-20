using Kingmaker.UI.MVVM._PCView.Settings.Entities;
using Kingmaker.UI.SettingsUI;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Settings.GammaCorrection {

public class GammaCorrectionPCView {
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HintText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPCView m_GammaSliderView /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPCView m_ContrastSliderView /* Kingmaker.UI.MVVM._PCView.Settings.Entities.SettingsEntitySliderPCView */;
    [SerializeField] public object m_ConfirmButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DefaultButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ConfirmButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DefaultButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.SettingsUI.UISettingsGroup m_GraphicsVisualPerceptionSettingsGroup /* Kingmaker.UI.SettingsUI.UISettingsGroup */;
}

}

