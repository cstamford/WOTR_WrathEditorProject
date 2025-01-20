using Kingmaker.View;
using System;
using UnityEngine;

namespace Kingmaker.View.MapObjects {

public class AreaEffectView {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintAbilityAreaEffectReference */;
    [SerializeField] public object m_Caster /* Kingmaker.Blueprints.BlueprintUnitReference */;
}

}

