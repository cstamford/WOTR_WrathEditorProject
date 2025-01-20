using Kingmaker.Settings;
using Kingmaker.Sound;
using Kingmaker.UI;
using Kingmaker.UI.MVVM._ConsoleView.Settings.GammaCorrection;
using Kingmaker.UI.MVVM._PCView.ChoseControllerMode;
using Kingmaker.UI.MVVM._PCView.Settings.GammaCorrection;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker {

public class GameStarter : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.Settings.SettingsValues m_SettingValues /* Kingmaker.Settings.SettingsValues */;
    [SerializeField] public global::Kingmaker.Sound.AudioFilePackagesSettings m_AudioFilePackagesSettings /* Kingmaker.Sound.AudioFilePackagesSettings */;
    public global::UnityEngine.GameObject ProgressBar /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.Image Progress /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_PressAnyKey /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChoseControllerMode.ChoseControllerModeWindowView m_ChoseControllerModeWindowView /* Kingmaker.UI.MVVM._PCView.ChoseControllerMode.ChoseControllerModeWindowView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.GammaCorrection.GammaCorrectionPCView m_GammaCorrectionPCView /* Kingmaker.UI.MVVM._PCView.Settings.GammaCorrection.GammaCorrectionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.GammaCorrection.GammaCorrectionConsoleView m_GammaCorrectionConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Settings.GammaCorrection.GammaCorrectionConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_LogoCanvas /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_SplashScreenCanvas /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_LogoImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ProgressBar /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ProgressBarImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.UICamera m_CameraPrefab /* Kingmaker.UI.UICamera */;
}

}

