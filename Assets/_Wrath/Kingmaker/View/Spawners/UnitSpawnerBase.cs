using Kingmaker.View;
using System;
using UnityEngine;

namespace Kingmaker.View.Spawners {

public class UnitSpawnerBase {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintUnitReference */;
    [SerializeField] public bool m_SpawnOnSceneInit /* System.Boolean */;
    [SerializeField] public bool m_RespawnIfDead /* System.Boolean */;
    [SerializeField] public object m_spawnConditions /* Kingmaker.ElementsSystem.ConditionsReference */;

    public class MyData {
    }

}

}

