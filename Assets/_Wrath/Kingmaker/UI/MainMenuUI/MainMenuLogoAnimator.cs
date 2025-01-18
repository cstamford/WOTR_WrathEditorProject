using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Kingmaker.UI.MainMenuUI {

public class MainMenuLogoAnimator : MonoBehaviour {
    [SerializeField] public Image m_Logo /* UnityEngine.UI.Image */;
    [SerializeField] public float m_LogoShowDelay /* System.Single */;
    [SerializeField] public float m_LogoHideDelay /* System.Single */;
    [SerializeField] public Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public float m_BackgroundShowDelay /* System.Single */;
    [SerializeField] public float m_BackgroundHideDelay /* System.Single */;
    [SerializeField] public UnityEvent m_LogoShown /* UnityEngine.Events.UnityEvent */;
}

}

