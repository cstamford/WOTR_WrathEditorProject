using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Kingmaker.UI.MainMenuUI {

public class SplashScreenController : MonoBehaviour {
    [SerializeField] public UnityEvent m_OnStartLogo /* UnityEngine.Events.UnityEvent */;
    [SerializeField] public UnityEvent m_OnStart /* UnityEngine.Events.UnityEvent */;
    [SerializeField] public List<SplashScreenController.ScreenUnit> m_Screens /* System.Collections.Generic.List<Kingmaker.UI.MainMenuUI.ScreenUnit> */;
    [SerializeField] public VideoPlayer m_PublisherVideoPlayer /* UnityEngine.Video.VideoPlayer */;
    [SerializeField] public RawImage m_PublisherRawImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public CanvasGroup m_OwlcatLogo /* UnityEngine.CanvasGroup */;
    [SerializeField] public CanvasGroup m_OwlcatTitle /* UnityEngine.CanvasGroup */;

    public class ScreenUnit {
        public CanvasGroup CanvasGroup /* UnityEngine.CanvasGroup */;
        public float InTime /* System.Single */;
        public float DelayTime /* System.Single */;
        public float OutTime /* System.Single */;
        public object Ease /* DG.Tweening.Ease */;
        public UnityEvent SupportAction /* UnityEngine.Events.UnityEvent */;
    }

}

}

