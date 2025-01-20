using System;
using UnityEngine;

namespace Kingmaker.View.MapObjects {

public class DynamicMapObjectView : global::Kingmaker.View.MapObjects.MapObjectView {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintDynamicMapObjectReference */;
}

}

