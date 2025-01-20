using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class FadeCanvas : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.RawImage m_FadeImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public float FadeTimer /* System.Single */;
    public global::System.Nullable<float> OverrideFadeTimer /* System.Nullable<System.Single> */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_Vignette /* UnityEngine.CanvasGroup */;
    [SerializeField] public float m_CutSceneTimer /* System.Single */;
    public global::Kingmaker.UI.FadeCanvas.PictureVariant PictureVar /* Kingmaker.UI.PictureVariant */;

    public enum PictureVariant {
        Black = 0,
        ScreenOn = 1,
        ScreenOff = 2,
        ScreenOnAndOff = 3,
    }

}

}

