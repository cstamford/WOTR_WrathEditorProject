using System;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class ParticlesMaterialController {
    [SerializeField] public global::UnityEngine.Texture2D TexColorAlphaRamp /* UnityEngine.Texture2D */;
    [SerializeField] public global::UnityEngine.Texture2D TexTrailColorRamp /* UnityEngine.Texture2D */;
    [SerializeField] public global::Kingmaker.Visual.Particles.ParticlesMaterialController.GradientUpdate m_TypeUpdate /* Kingmaker.Visual.Particles.GradientUpdate */;
    [SerializeField] public global::Kingmaker.Visual.Particles.ParticlesMaterialController.GradientUpdate m_TrailTypeUpdate /* Kingmaker.Visual.Particles.GradientUpdate */;
    public global::UnityEngine.Gradient ColorAlphaRamp /* UnityEngine.Gradient */;
    public global::UnityEngine.Gradient TrailColorAlphaRamp /* UnityEngine.Gradient */;
    public bool RandomizeNoiseUv /* System.Boolean */;
    public bool RandomizeColorRampOffset /* System.Boolean */;
    public bool UnscaledTime /* System.Boolean */;

    public enum GradientUpdate {
        Unknown = 0,
        AlreadyBake = 1,
        AutoBake = 2,
    }

}

}

