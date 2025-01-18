using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class LowResParticlesRenderer : MonoBehaviour {
    public LayerMask CullingMask /* UnityEngine.LayerMask */;
    public LowResParticlesRenderer.Downscale DownscaleValue /* Kingmaker.Visual.Particles.Downscale */;
    public Shader LowResParticlesShader /* UnityEngine.Shader */;

    public enum Downscale {
        Downscale2x2 = 2,
        Downscale4x4 = 4,
        Downscale16x16Debug = 16,
    }

}

}

