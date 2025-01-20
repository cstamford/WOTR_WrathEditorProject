using System;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class LowResParticlesRenderer : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.LayerMask CullingMask /* UnityEngine.LayerMask */;
    public global::Kingmaker.Visual.Particles.LowResParticlesRenderer.Downscale DownscaleValue /* Kingmaker.Visual.Particles.Downscale */;
    public global::UnityEngine.Shader LowResParticlesShader /* UnityEngine.Shader */;

    public enum Downscale {
        Downscale2x2 = 2,
        Downscale4x4 = 4,
        Downscale16x16Debug = 16,
    }

}

}

