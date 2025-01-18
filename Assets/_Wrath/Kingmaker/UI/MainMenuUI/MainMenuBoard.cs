using UnityEngine;

namespace Kingmaker.UI.MainMenuUI {

public class MainMenuBoard : MonoBehaviour {
    [SerializeField] public MainMenuCameraAnchors m_CameraAnchors /* Kingmaker.UI.MainMenuUI.MainMenuCameraAnchors */;
    [SerializeField] public MainMenuCameraController m_CameraController /* Kingmaker.UI.MainMenuUI.MainMenuCameraController */;
    [SerializeField] public MainMenuLightController m_LightController /* Kingmaker.UI.MainMenuUI.MainMenuLightController */;
    [SerializeField] public Camera m_Camera /* UnityEngine.Camera */;
    [SerializeField] public Animator m_FadeOutAnimator /* UnityEngine.Animator */;
}

}

