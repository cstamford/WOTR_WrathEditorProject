using Kingmaker.UI.MVVM._ConsoleView.Settings.Entities;
using Kingmaker.UI.SettingsUI;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Settings.GammaCorrection {

public class GammaCorrectionConsoleView {
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HintText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView m_GammaSliderView /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView m_ContrastSliderView /* Kingmaker.UI.MVVM._ConsoleView.Settings.Entities.SettingsEntitySliderConsoleView */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.SettingsUI.UISettingsGroup m_GraphicsVisualPerceptionSettingsGroup /* Kingmaker.UI.SettingsUI.UISettingsGroup */;
}

}

