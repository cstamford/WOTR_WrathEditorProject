using System;
using UnityEngine;

namespace Kingmaker.View.MapObjects {

public class FinneanCampObject : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_VisibleConditions /* Kingmaker.ElementsSystem.ConditionsReference */;
    [SerializeField] public object m_ObjectBlueprint /* Kingmaker.Blueprints.BlueprintDynamicMapObjectReference */;
}

}

