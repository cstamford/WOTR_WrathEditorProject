using Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ChangeVisual {

public class ChangeVisualPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryDollPCView m_DollView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryDollPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualInventoryStashPCView m_Inventory /* Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualInventoryStashPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualSecondaryItemsView m_SecondaryItemsView /* Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualSecondaryItemsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualSlotPCView m_PrimarySlot /* Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualSlotPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualSlotPCView m_SecondarySlot /* Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualSlotPCView */;
    [SerializeField] public object m_Close /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ChangeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_InventoryButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ActionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_InventoryText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SourceItemText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TargetItemText /* TMPro.TextMeshProUGUI */;
}

}

