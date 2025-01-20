using System;
using UnityEngine;

namespace Kingmaker.UI.MainMenuUI {

public class MainMenuBoard : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.MainMenuUI.MainMenuCameraAnchors m_CameraAnchors /* Kingmaker.UI.MainMenuUI.MainMenuCameraAnchors */;
    [SerializeField] public global::Kingmaker.UI.MainMenuUI.MainMenuCameraController m_CameraController /* Kingmaker.UI.MainMenuUI.MainMenuCameraController */;
    [SerializeField] public global::Kingmaker.UI.MainMenuUI.MainMenuLightController m_LightController /* Kingmaker.UI.MainMenuUI.MainMenuLightController */;
    [SerializeField] public global::UnityEngine.Camera m_Camera /* UnityEngine.Camera */;
    [SerializeField] public global::UnityEngine.Animator m_FadeOutAnimator /* UnityEngine.Animator */;
}

}

