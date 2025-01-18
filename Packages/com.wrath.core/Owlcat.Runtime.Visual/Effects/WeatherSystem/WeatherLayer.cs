using System.Collections.Generic;
using UnityEngine;

namespace Owlcat.Runtime.Visual.Effects.WeatherSystem {

public class WeatherLayer : ScriptableObject {
    public object FogSettings /* Owlcat.Runtime.Visual.Effects.WeatherSystem.FogSettings */;
    public object DecalSettings /* Owlcat.Runtime.Visual.Effects.WeatherSystem.DecalSettings */;
    public object PostProcessVolumeSettings /* Owlcat.Runtime.Visual.Effects.WeatherSystem.PostProcessVolumeSettings */;
    public object Effects /* System.Collections.Generic.List */;
    public List<WeatherCustomEntitySettings> CustomEffects /* System.Collections.Generic.List<Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherCustomEntitySettings> */;
}

}

