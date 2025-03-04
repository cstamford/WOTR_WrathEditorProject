using System;
using UnityEngine;

namespace Kingmaker.Visual.WaterInteraction {

public class WaterInteractionEmitter : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.Visual.WaterInteraction.WaterInteractionEmitter.EmitterSettings Settings /* Kingmaker.Visual.WaterInteraction.EmitterSettings */;

    public class EmitterSettings {
        public float Delay /* System.Single */;
        public float Duration /* System.Single */;
        public float RateOverTime /* System.Single */;
        public float RateOverDistance /* System.Single */;
        public global::UnityEngine.Vector2 Lifetime /* UnityEngine.Vector2 */;
        public global::UnityEngine.Vector2 Size /* UnityEngine.Vector2 */;
        public float RandomizePositionRadius /* System.Single */;
    }

}

}

