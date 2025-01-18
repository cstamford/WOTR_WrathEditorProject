using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.GameOver {

public class EndOfGameObject : MonoBehaviour {
    [SerializeField] public CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public Material m_Material /* UnityEngine.Material */;
    [SerializeField] public Image m_Image /* UnityEngine.UI.Image */;
    [SerializeField] public float m_DelayBeforeStart /* System.Single */;
    [SerializeField] public float m_FadeOut /* System.Single */;
    [SerializeField] public float m_DelayBeforeText /* System.Single */;
    [SerializeField] public float m_AppearText /* System.Single */;
    [SerializeField] public float m_FadeIn /* System.Single */;
    [SerializeField] public AnimationCurve m_FadeOutEase /* UnityEngine.AnimationCurve */;
    [SerializeField] public AnimationCurve m_FadeInEase /* UnityEngine.AnimationCurve */;
}

}

