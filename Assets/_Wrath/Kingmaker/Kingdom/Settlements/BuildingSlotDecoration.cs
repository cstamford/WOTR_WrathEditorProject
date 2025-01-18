using System;
using UnityEngine;

namespace Kingmaker.Kingdom.Settlements {

public class BuildingSlotDecoration : MonoBehaviour {
    public string SlotId /* System.String */;
    public GameObject Decoration /* UnityEngine.GameObject */;
    [SerializeField] public object m_SpecificBuildings /* Kingmaker.Blueprints.BlueprintSettlementBuildingReference[] */;
    public bool ShowIfFinished /* System.Boolean */;
    public bool ShowIfUnfinished /* System.Boolean */;
    public object MinLevel /* Kingmaker.Kingdom.Settlements.LevelType */;
    public bool Invert /* System.Boolean */;
}

}

