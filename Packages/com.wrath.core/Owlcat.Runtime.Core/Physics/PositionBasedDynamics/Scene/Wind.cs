using System;
using UnityEngine;

namespace Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene {

public class Wind : MonoBehaviour {
    public object Direction /* Unity.Mathematics.float2 */;
    public float Intensity /* System.Single */;
    public float StrengthNoiseWeight /* System.Single */;
    public float StrengthNoiseContrast /* System.Single */;
    public Wind.NoiseOctave StrenghtOctave0 /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene.NoiseOctave */;
    public Wind.NoiseOctave StrengthOctave1 /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene.NoiseOctave */;
    public Wind.NoiseOctave ShiftOctave0 /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene.NoiseOctave */;
    public Wind.NoiseOctave ShiftOctave1 /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene.NoiseOctave */;

    public class NoiseOctave {
        public float Weight /* System.Single */;
        public float Scale /* System.Single */;
        public float MoveSpeed /* System.Single */;
    }

}

}

