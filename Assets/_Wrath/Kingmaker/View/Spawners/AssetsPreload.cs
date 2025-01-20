using System;
using UnityEngine;

namespace Kingmaker.View.Spawners {

public class AssetsPreload : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Units /* Kingmaker.Blueprints.BlueprintUnitReference[] */;
    public object Prefabs /* Kingmaker.ResourceLinks.PrefabLink[] */;
}

}

