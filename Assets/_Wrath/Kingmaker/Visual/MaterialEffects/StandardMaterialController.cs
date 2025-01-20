using System;
using UnityEngine;

namespace Kingmaker.Visual.MaterialEffects {

public class StandardMaterialController {
    [SerializeField] public object m_ColorTintController /* Kingmaker.Visual.MaterialEffects.ColorTint.ColorTintAnimationController */;
    [SerializeField] public object m_RimController /* Kingmaker.Visual.MaterialEffects.RimLighting.RimLightingAnimationController */;
    [SerializeField] public object m_DissolveController /* Kingmaker.Visual.MaterialEffects.Dissolve.DissolveAnimationController */;
    [SerializeField] public object m_AdditionalAlbedoController /* Kingmaker.Visual.MaterialEffects.AdditionalAlbedo.AdditionalAlbedoAnimationController */;
    [SerializeField] public object m_MaterialParametersOverrideController /* Kingmaker.Visual.MaterialEffects.MaterialParametersOverride.MaterialParametersOverrideController */;
}

}

