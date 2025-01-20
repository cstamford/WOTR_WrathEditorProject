using System;
using UnityEngine;

namespace Kingmaker.Dungeon.Blueprints {

public class DungeonLocatorUnitView : global::Kingmaker.Dungeon.Blueprints.DungeonLocatorView {
    public bool IsMelee /* System.Boolean */;
    public bool IsRanged /* System.Boolean */;
    public bool IsCaster /* System.Boolean */;
    public bool IsStill /* System.Boolean */;
    public float Probability /* System.Single */;
    [SerializeField] public object m_Army /* Kingmaker.Dungeon.Blueprints.BlueprintDungeonArmyReference */;
    [SerializeField] public object m_SummonPool /* Kingmaker.Blueprints.BlueprintSummonPoolReference */;
}

}

