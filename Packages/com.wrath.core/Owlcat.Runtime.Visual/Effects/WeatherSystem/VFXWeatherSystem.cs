using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.Effects.WeatherSystem {

public class VFXWeatherSystem : MonoBehaviour {
    public Camera Camera /* UnityEngine.Camera */;
    public bool UseDebugParams /* System.Boolean */;
    public float DebugWeatherIntensity /* System.Single */;
    public bool LerpWindIntensity /* System.Boolean */;
    public float DebugWindIntensity /* System.Single */;
    public Vector2 DebugWindDirection /* UnityEngine.Vector2 */;
    public object DebugWeatherProfile /* Owlcat.Runtime.Visual.Effects.WeatherSystem.WeatherProfileExtended */;
}

}

