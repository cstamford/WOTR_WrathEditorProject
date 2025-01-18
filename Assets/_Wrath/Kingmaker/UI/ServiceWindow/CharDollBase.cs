using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class CharDollBase : MonoBehaviour {
    [SerializeField] public object m_EquipSlot /* Kingmaker.UI.GenericSlot.EquipSlotBase */;
    [SerializeField] public float m_DollRoomMinZoom /* System.Single */;
    [SerializeField] public DollRoomCharacterController m_CharacterController /* Kingmaker.UI.ServiceWindow.DollRoomCharacterController */;
    public List<CharDollBase.SlotPosPair> SlotPosPairs /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.SlotPosPair> */;
    [SerializeField] public object m_DollWeaponSets /* Kingmaker.UI.ServiceWindow.DollWeaponSets */;

    public class SlotPosPair {
        public object Type /* Kingmaker.UI.GenericSlot.SlotType */;
        public Transform Position /* UnityEngine.Transform */;
    }

}

}

