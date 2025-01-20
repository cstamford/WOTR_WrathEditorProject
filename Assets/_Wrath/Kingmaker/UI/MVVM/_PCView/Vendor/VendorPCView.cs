using Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory;
using Kingmaker.UI.MVVM._PCView.Slots;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Vendor {

public class VendorPCView {
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_VendorName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_VendorGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemsFilterPCView m_VendorItemsFilter /* Kingmaker.UI.MVVM._PCView.Slots.ItemsFilterPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Vendor.VendorSlotPCView m_VendorSlotPrefab /* Kingmaker.UI.MVVM._PCView.Vendor.VendorSlotPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_Placeholder /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryDollPCView m_DollView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryDollPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryStashPCView m_StashView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryStashPCView */;
    [SerializeField] public object m_CharacterName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Vendor.VendorOptionsPCView m_OptionsView /* Kingmaker.UI.MVVM._PCView.Vendor.VendorOptionsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_PlayerExchangeGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_VendorExchangeGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Vendor.VendorGenericSlotPCView m_VendorGenericSlotView /* Kingmaker.UI.MVVM._PCView.Vendor.VendorGenericSlotPCView */;
    [SerializeField] public object m_PlayerReturnButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_VendorReturnButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_VendorWeightText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PlayerWeightText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MassSaleButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_MassSaleLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_OptionsButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DealButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DealLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BackToStashButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_BackToStashLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DealPrice /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_LeftArrow /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_RightArrow /* UnityEngine.GameObject */;
}

}

