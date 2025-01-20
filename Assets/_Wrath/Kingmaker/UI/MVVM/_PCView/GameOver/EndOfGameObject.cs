using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.GameOver {

public class EndOfGameObject : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.Material m_Material /* UnityEngine.Material */;
    [SerializeField] public global::UnityEngine.UI.Image m_Image /* UnityEngine.UI.Image */;
    [SerializeField] public float m_DelayBeforeStart /* System.Single */;
    [SerializeField] public float m_FadeOut /* System.Single */;
    [SerializeField] public float m_DelayBeforeText /* System.Single */;
    [SerializeField] public float m_AppearText /* System.Single */;
    [SerializeField] public float m_FadeIn /* System.Single */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_FadeOutEase /* UnityEngine.AnimationCurve */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_FadeInEase /* UnityEngine.AnimationCurve */;
}

}

