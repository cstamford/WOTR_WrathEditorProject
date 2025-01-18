using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.View.Equipment {

public class EquipmentOffsets : MonoBehaviour {
    [SerializeField] public EquipmentOffsets.Offsets m_MainHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public EquipmentOffsets.Offsets m_OffHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public EquipmentOffsets.Offsets m_DollRoomMainHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public EquipmentOffsets.Offsets m_DollRoomOffHand /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public EquipmentOffsets.Offsets m_DollRoomIKRight /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public EquipmentOffsets.Offsets m_DollRoomIKLeft /* Kingmaker.View.Equipment.Offsets */;
    [SerializeField] public object m_SlotOffsets /* Kingmaker.View.Equipment.Offsets[] */;
    public bool BackpackOffsets /* System.Boolean */;
    public Transform JointsParent /* UnityEngine.Transform */;
    public Transform IkTargetLeftHand /* UnityEngine.Transform */;
    public Transform IkTargetRightHand /* UnityEngine.Transform */;
    public List<EquipmentOffsets.RaceOffset> raceOffset /* System.Collections.Generic.List<Kingmaker.View.Equipment.RaceOffset> */;

    public class Offsets {
        public Vector3 Position /* UnityEngine.Vector3 */;
        public Vector3 Rotation /* UnityEngine.Vector3 */;
    }

    public class RaceOffset {
        public object race /* Kingmaker.Blueprints.Race */;
        public Vector3 OffsetLeftIk /* UnityEngine.Vector3 */;
    }

}

}

