using Kingmaker.UI.GenericSlot;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class DollWeaponSet {
    [SerializeField] public global::Kingmaker.UI.GenericSlot.EquipSlotBase m_EquipSlot /* Kingmaker.UI.GenericSlot.EquipSlotBase */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharDollBase.SlotPosPair> SlotPosPairs /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.SlotPosPair> */;
    [SerializeField] public object m_IndexLabel /* TMPro.TextMeshProUGUI */;
}

}

