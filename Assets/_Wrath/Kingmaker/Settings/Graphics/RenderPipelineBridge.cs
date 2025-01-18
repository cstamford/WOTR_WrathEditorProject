using UnityEngine;
using UnityEngine.Rendering;

namespace Kingmaker.Settings.Graphics {

public class RenderPipelineBridge : ScriptableObject {
    public RenderPipelineAsset RenderPipelineAsset /* UnityEngine.Rendering.RenderPipelineAsset */;
    public VolumeProfile GammaProfile /* UnityEngine.Rendering.VolumeProfile */;
}

}

