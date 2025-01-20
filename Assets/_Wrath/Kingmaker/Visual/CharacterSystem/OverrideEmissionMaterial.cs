using System;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class OverrideEmissionMaterial : global::UnityEngine.MonoBehaviour {
    [SerializeField] public bool m_Emission /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Texture2D m_Texture /* UnityEngine.Texture2D */;
    [SerializeField] public global::Kingmaker.Visual.CharacterSystem.OverrideEmissionMaterial.MapUsage m_MapUsage /* Kingmaker.Visual.CharacterSystem.MapUsage */;
    [SerializeField] public global::UnityEngine.Color m_Color /* UnityEngine.Color */;
    [SerializeField] public float m_ColorFactor /* System.Single */;
    [SerializeField] public float m_ColorIntensity /* System.Single */;
    [SerializeField] public float m_AlbedoSuppression /* System.Single */;
    [SerializeField] public float m_LighmapColorScale /* System.Single */;

    public enum MapUsage {
        RGB = 0,
        Alpha = 1,
    }

}

}

