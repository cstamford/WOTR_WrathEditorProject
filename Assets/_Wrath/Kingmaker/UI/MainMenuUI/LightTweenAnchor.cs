using System;
using UnityEngine;

namespace Kingmaker.UI.MainMenuUI {

public class LightTweenAnchor : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.MainMenuUI.LightTweenAnchor.TweenLightData m_DefaultTween /* Kingmaker.UI.MainMenuUI.TweenLightData */;
    [SerializeField] public object m_Tweens /* Kingmaker.UI.MainMenuUI.TweenLightDataWithPrev[] */;
    public float Intensivity /* System.Single */;
    public float Range /* System.Single */;

    public class TweenLightData {
        public float RubberBandIntensity /* System.Single */;
        public float RubberBandRange /* System.Single */;
        public float AnimationTime /* System.Single */;
        public bool UseEasing /* System.Boolean */;
        public bool SeparateCurves /* System.Boolean */;
        public VectorSpline AnimationTrack /* .VectorSpline */;
        public global::UnityEngine.AnimationCurve AnimationCurve /* UnityEngine.AnimationCurve */;
        public VectorSpline LootAtTrack /* .VectorSpline */;
        public global::UnityEngine.AnimationCurve LookAtCurve /* UnityEngine.AnimationCurve */;
    }

    public class TweenLightDataWithPrev : global::Kingmaker.UI.MainMenuUI.LightTweenAnchor.TweenLightData {
        public global::Kingmaker.UI.MainMenuUI.LightTweenAnchor PreviousAnchor /* Kingmaker.UI.MainMenuUI.LightTweenAnchor */;
    }

}

}

