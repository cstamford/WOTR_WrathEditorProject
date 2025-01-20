using Kingmaker.UI.GenericSlot;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class CharDollBase : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.GenericSlot.EquipSlotBase m_EquipSlot /* Kingmaker.UI.GenericSlot.EquipSlotBase */;
    [SerializeField] public float m_DollRoomMinZoom /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.DollRoomCharacterController m_CharacterController /* Kingmaker.UI.ServiceWindow.DollRoomCharacterController */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharDollBase.SlotPosPair> SlotPosPairs /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.SlotPosPair> */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.DollWeaponSets m_DollWeaponSets /* Kingmaker.UI.ServiceWindow.DollWeaponSets */;

    public class SlotPosPair {
        public global::Kingmaker.UI.GenericSlot.EquipSlotBase.SlotType Type /* Kingmaker.UI.GenericSlot.SlotType */;
        public global::UnityEngine.Transform Position /* UnityEngine.Transform */;
    }

}

}

