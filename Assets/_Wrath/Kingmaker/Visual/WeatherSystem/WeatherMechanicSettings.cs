using System;
using UnityEngine;

namespace Kingmaker.Visual.WeatherSystem {

public class WeatherMechanicSettings {
    public double CastAbilityEvery /* System.Double */;
    [SerializeField] public object m_InclemencyType /* Owlcat.Runtime.Visual.Effects.WeatherSystem.InclemencyType */;
    [SerializeField] public object m_WeatherEffectsDifficulty /* Kingmaker.Settings.WeatherEffects */;
    [SerializeField] public object m_Target /* Kingmaker.Visual.WeatherSystem.WeatherAbilityTarget */;
    [SerializeField] public object m_BlueprintActor /* Kingmaker.Blueprints.BlueprintUnitReference */;
    [SerializeField] public object m_BlueprintAbility /* Kingmaker.Blueprints.BlueprintAbilityReference */;
    [SerializeField] public object m_BlueprintBuff /* Kingmaker.Blueprints.BlueprintBuffReference */;
}

}

