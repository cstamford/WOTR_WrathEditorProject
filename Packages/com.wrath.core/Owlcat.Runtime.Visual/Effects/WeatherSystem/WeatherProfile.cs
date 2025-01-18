using UnityEngine;

namespace Owlcat.Runtime.Visual.Effects.WeatherSystem {

public class WeatherProfile : ScriptableObject {
    [SerializeField] public object m_SeasonalData /* Owlcat.Runtime.Visual.Effects.WeatherSystem.SeasonalData */;
    [SerializeField] public object m_InclemencyIntensityRanges /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherMinMaxArray */;
    [SerializeField] public object m_Layers /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherLayer[] */;
    [SerializeField] public object m_CustomEffects /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherCustomEntitySettings[] */;
    [SerializeField] public object m_DirectionalLightSettings /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherDirectionalLightSettings */;
    [SerializeField] public WindProfile m_WindProfile /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WindProfile */;
    [SerializeField] public object m_BakeProfile /* Owlcat.Runtime.Visual.Effects.WeatherSystem.VFXLocationWeatherDataProfile */;
}

}

