using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.Data {

public class PostProcessData : ScriptableObject {
    public PostProcessData.ShaderResources Shaders /* Owlcat.Runtime.Visual.RenderPipeline.Data.ShaderResources */;
    public PostProcessData.TextureResources Textures /* Owlcat.Runtime.Visual.RenderPipeline.Data.TextureResources */;

    public class ShaderResources {
        public Shader StopNanPS /* UnityEngine.Shader */;
        public Shader SubpixelMorphologicalAntialiasingPS /* UnityEngine.Shader */;
        public Shader GaussianDepthOfFieldPS /* UnityEngine.Shader */;
        public Shader BokehDepthOfFieldPS /* UnityEngine.Shader */;
        public Shader CameraMotionBlurPS /* UnityEngine.Shader */;
        public Shader PaniniProjectionPS /* UnityEngine.Shader */;
        public Shader LutBuilderLdrPS /* UnityEngine.Shader */;
        public Shader LutBuilderHdrPS /* UnityEngine.Shader */;
        public Shader BloomPS /* UnityEngine.Shader */;
        public Shader BloomEnhancedPS /* UnityEngine.Shader */;
        public Shader RadialBlurPS /* UnityEngine.Shader */;
        public Shader SaturationOverlayPS /* UnityEngine.Shader */;
        public Shader MaskedColorTransformPS /* UnityEngine.Shader */;
        public Shader UberPostPS /* UnityEngine.Shader */;
        public Shader FinalPostPassPS /* UnityEngine.Shader */;
        public Shader DaltonizationPS /* UnityEngine.Shader */;
    }

    public class TextureResources {
        public Texture2D[] BlueNoise16LTex /* UnityEngine.Texture2D[] */;
        public Texture2D[] FilmGrainTex /* UnityEngine.Texture2D[] */;
        public Texture2D SmaaAreaTex /* UnityEngine.Texture2D */;
        public Texture2D SmaaSearchTex /* UnityEngine.Texture2D */;
    }

}

}

