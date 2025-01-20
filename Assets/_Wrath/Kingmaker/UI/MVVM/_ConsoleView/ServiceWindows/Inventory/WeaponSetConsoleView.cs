using Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory {

public class WeaponSetConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryEquipSlotView m_PrimaryHand /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryEquipSlotView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryEquipSlotView m_SecondaryHand /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryEquipSlotView */;
    [SerializeField] public object m_WeaponSetIndex /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_GripButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

