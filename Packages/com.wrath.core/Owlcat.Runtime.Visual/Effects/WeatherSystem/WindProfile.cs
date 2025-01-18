using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.Effects.WeatherSystem {

public class WindProfile : ScriptableObject {
    [SerializeField] public object m_SeasonalData /* Owlcat.Runtime.Visual.Effects.WeatherSystem.SeasonalData */;
    public object WindIntensityRanges /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherMinMaxArray */;
    public object WindLerpValues /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherArray */;
    public object StrengthNoiseSettings /* Owlcat.Runtime.Visual.Effects.WeatherSystem.NoiseSettings */;
    public object ShiftNoiseSettings /* Owlcat.Runtime.Visual.Effects.WeatherSystem.NoiseSettings */;
    public float StrengthNoiseWeight /* System.Single */;
    public float StrengthNoiseContrast /* System.Single */;
}

}

