using Kingmaker.Settings;
using Kingmaker.Sound;
using Kingmaker.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker {

public class GameStarter : MonoBehaviour {
    [SerializeField] public SettingsValues m_SettingValues /* Kingmaker.Settings.SettingsValues */;
    [SerializeField] public AudioFilePackagesSettings m_AudioFilePackagesSettings /* Kingmaker.Sound.AudioFilePackagesSettings */;
    public GameObject ProgressBar /* UnityEngine.GameObject */;
    public Image Progress /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_PressAnyKey /* UnityEngine.GameObject */;
    [SerializeField] public object m_ChoseControllerModeWindowView /* Kingmaker.UI.MVVM._PCView.ChoseControllerMode.ChoseControllerModeWindowView */;
    [SerializeField] public object m_GammaCorrectionPCView /* Kingmaker.UI.MVVM._PCView.Settings.GammaCorrection.GammaCorrectionPCView */;
    [SerializeField] public object m_GammaCorrectionConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Settings.GammaCorrection.GammaCorrectionConsoleView */;
    [SerializeField] public GameObject m_LogoCanvas /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_SplashScreenCanvas /* UnityEngine.GameObject */;
    [SerializeField] public Image m_LogoImage /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ProgressBar /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ProgressBarImage /* UnityEngine.UI.Image */;
    [SerializeField] public UICamera m_CameraPrefab /* Kingmaker.UI.UICamera */;
}

}

