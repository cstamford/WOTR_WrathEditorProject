using System;
using UnityEngine;

namespace Kingmaker.View.Spawners.Components {

public class SpawnerCorpseInteraction {
    [SerializeField] public object m_Settings /* Kingmaker.View.MapObjects.InteractionSkillCheckSettings */;
    [SerializeField] public object m_ObjectReference /* Kingmaker.Blueprints.BlueprintDynamicMapObjectReference */;
    [SerializeField] public bool m_EnableInteractionOnDeath /* System.Boolean */;
}

}

