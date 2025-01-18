using System;
using UnityEngine;

namespace Kingmaker.UI.MainMenuUI {

public class LightTweenAnchor : MonoBehaviour {
    [SerializeField] public LightTweenAnchor.TweenLightData m_DefaultTween /* Kingmaker.UI.MainMenuUI.TweenLightData */;
    [SerializeField] public object m_Tweens /* Kingmaker.UI.MainMenuUI.TweenLightDataWithPrev[] */;
    public float Intensivity /* System.Single */;
    public float Range /* System.Single */;

    public class TweenLightData {
        public float RubberBandIntensity /* System.Single */;
        public float RubberBandRange /* System.Single */;
        public float AnimationTime /* System.Single */;
        public bool UseEasing /* System.Boolean */;
        public bool SeparateCurves /* System.Boolean */;
        public object AnimationTrack /* .VectorSpline */;
        public AnimationCurve AnimationCurve /* UnityEngine.AnimationCurve */;
        public object LootAtTrack /* .VectorSpline */;
        public AnimationCurve LookAtCurve /* UnityEngine.AnimationCurve */;
    }

    public class TweenLightDataWithPrev : LightTweenAnchor.TweenLightData {
        public object PreviousAnchor /* Kingmaker.UI.MainMenuUI.LightTweenAnchor */;
    }

}

}

