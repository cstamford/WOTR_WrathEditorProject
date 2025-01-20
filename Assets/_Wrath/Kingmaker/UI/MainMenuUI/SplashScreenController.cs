using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Kingmaker.UI.MainMenuUI {

public class SplashScreenController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Events.UnityEvent m_OnStartLogo /* UnityEngine.Events.UnityEvent */;
    [SerializeField] public global::UnityEngine.Events.UnityEvent m_OnStart /* UnityEngine.Events.UnityEvent */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MainMenuUI.SplashScreenController.ScreenUnit> m_Screens /* System.Collections.Generic.List<Kingmaker.UI.MainMenuUI.ScreenUnit> */;
    [SerializeField] public global::UnityEngine.Video.VideoPlayer m_PublisherVideoPlayer /* UnityEngine.Video.VideoPlayer */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_PublisherRawImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_OwlcatLogo /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_OwlcatTitle /* UnityEngine.CanvasGroup */;

    public class ScreenUnit {
        public global::UnityEngine.CanvasGroup CanvasGroup /* UnityEngine.CanvasGroup */;
        public float InTime /* System.Single */;
        public float DelayTime /* System.Single */;
        public float OutTime /* System.Single */;
        public object Ease /* DG.Tweening.Ease */;
        public global::UnityEngine.Events.UnityEvent SupportAction /* UnityEngine.Events.UnityEvent */;
    }

}

}

