using Kingmaker.View.MapObjects;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Kingdom.Settlements {

public class BuildingSlot : global::Kingmaker.View.MapObjects.MapObjectView {
    public object SpecialType /* Kingmaker.Kingdom.Settlements.SpecialSlotType */;
    public object MinLevel /* Kingmaker.Kingdom.Settlements.LevelType */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> m_MeshRenderers /* System.Collections.Generic.List<UnityEngine.MeshRenderer> */;
    [SerializeField] public string m_SlotId /* System.String */;
    public global::Kingmaker.Kingdom.Settlements.BuildingSlotGrid Grid /* Kingmaker.Kingdom.Settlements.BuildingSlotGrid */;
    public int GridX /* System.Int32 */;
    public int GridY /* System.Int32 */;
}

}

