using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.View.Equipment {

public class EquipmentOffsets : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.View.Equipment.EquipmentOffsets.Offsets m_MainHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public global::Kingmaker.View.Equipment.EquipmentOffsets.Offsets m_OffHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public global::Kingmaker.View.Equipment.EquipmentOffsets.Offsets m_DollRoomMainHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public global::Kingmaker.View.Equipment.EquipmentOffsets.Offsets m_DollRoomOffHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public global::Kingmaker.View.Equipment.EquipmentOffsets.Offsets m_DollRoomIKRight /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public global::Kingmaker.View.Equipment.EquipmentOffsets.Offsets m_DollRoomIKLeft /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public object m_SlotOffsets /* Kingmaker.View.Equipment.Offsets[] */;
    public bool BackpackOffsets /* System.Boolean */;
    public global::UnityEngine.Transform JointsParent /* UnityEngine.Transform */;
    public global::UnityEngine.Transform IkTargetLeftHand /* UnityEngine.Transform */;
    public global::UnityEngine.Transform IkTargetRightHand /* UnityEngine.Transform */;
    public global::System.Collections.Generic.List<global::Kingmaker.View.Equipment.EquipmentOffsets.RaceOffset> raceOffset /* System.Collections.Generic.List<Kingmaker.View.Equipment.RaceOffset> */;

    public class Offsets {
        public global::UnityEngine.Vector3 Position /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 Rotation /* UnityEngine.Vector3 */;
    }

    public class RaceOffset {
        public object race /* Kingmaker.Blueprints.Race */;
        public global::UnityEngine.Vector3 OffsetLeftIk /* UnityEngine.Vector3 */;
    }

}

}

