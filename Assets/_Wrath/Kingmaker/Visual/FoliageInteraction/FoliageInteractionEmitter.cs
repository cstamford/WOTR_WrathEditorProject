using System;
using UnityEngine;

namespace Kingmaker.Visual.FoliageInteraction {

public class FoliageInteractionEmitter : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.Visual.FoliageInteraction.FoliageInteractionEmitter.EmitterSettings Settings /* Kingmaker.Visual.FoliageInteraction.EmitterSettings */;

    public class ScaleCurve {
        [SerializeField] public global::UnityEngine.Vector2 m_KeysTime /* UnityEngine.Vector2 */;
        [SerializeField] public float m_Value0 /* System.Single */;
        [SerializeField] public float m_Value1 /* System.Single */;
    }

    public class EmitterSettings {
        public float Delay /* System.Single */;
        public float Duration /* System.Single */;
        public float RateOverTime /* System.Single */;
        public float RateOverDistance /* System.Single */;
        public global::UnityEngine.Vector2 Lifetime /* UnityEngine.Vector2 */;
        public global::UnityEngine.Vector2 Size /* UnityEngine.Vector2 */;
        public float RandomizePositionRadius /* System.Single */;
        public global::UnityEngine.Vector2 RandomizeRotation /* UnityEngine.Vector2 */;
        public float RadialWeight /* System.Single */;
        public global::UnityEngine.Vector2 InOutBalance /* UnityEngine.Vector2 */;
        public global::UnityEngine.Vector2 FrequencyScale /* UnityEngine.Vector2 */;
        public float RandomizePhaseOffset /* System.Single */;
        public global::Kingmaker.Visual.FoliageInteraction.FoliageInteractionEmitter.ScaleCurve ScaleCurve /* Kingmaker.Visual.FoliageInteraction.ScaleCurve */;
    }

}

}

