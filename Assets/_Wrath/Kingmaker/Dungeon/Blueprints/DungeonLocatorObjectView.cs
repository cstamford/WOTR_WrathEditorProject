using System;
using UnityEngine;

namespace Kingmaker.Dungeon.Blueprints {

public class DungeonLocatorObjectView : global::Kingmaker.Dungeon.Blueprints.DungeonLocatorView {
    [SerializeField] public object m_ModificatorsInclude /* Kingmaker.Dungeon.Blueprints.BlueprintDungeonModificatorReference[] */;
    [SerializeField] public object m_ModificatorsExclude /* Kingmaker.Dungeon.Blueprints.BlueprintDungeonModificatorReference[] */;
}

}

