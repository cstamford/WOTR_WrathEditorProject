using System;
using UnityEngine;

namespace Kingmaker.Assets.UI {

public class CanvasAnimation : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object Canvases /* Kingmaker.Assets.UI.CanvasEntry[] */;

    public class CanvasEntry {
        public global::UnityEngine.CanvasGroup Canvas /* UnityEngine.CanvasGroup */;
        public float FadeTime /* System.Single */;
        public float UnfadeTime /* System.Single */;
        public float FadeDelay /* System.Single */;
        public float UnfadeDelay /* System.Single */;
    }

}

}

