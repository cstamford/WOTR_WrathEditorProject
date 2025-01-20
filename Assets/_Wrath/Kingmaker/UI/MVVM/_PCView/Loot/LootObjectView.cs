using Kingmaker.UI.MVVM._PCView.Slots;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Loot {

public class LootObjectView {
    [SerializeField] public object m_ObjectsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_SlotsGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Loot.LootSlotView m_SlotPrefab /* Kingmaker.UI.MVVM._PCView.Loot.LootSlotView */;
    [SerializeField] public bool m_IsChest /* System.Boolean */;
    [SerializeField] public object m_LayoutSettings /* Owlcat.Runtime.UI.VirtualListSystem.ElementSettings.VirtualListLayoutElementSettings */;
}

}

