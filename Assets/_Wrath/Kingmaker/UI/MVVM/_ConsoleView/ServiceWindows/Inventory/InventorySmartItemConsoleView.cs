using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory {

public class InventorySmartItemConsoleView {
    [SerializeField] public object m_TitleLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_UnitPortrait /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StartDialogButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_StartDialogButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_StartDialogObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_ItemSelectorButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_ItemSelectorButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_ItemSelectorObject /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.SmartItemSlotConsoleView m_SmartItemSlotView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.SmartItemSlotConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryEquipSelectorConsoleView m_EquipSelectorConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryEquipSelectorConsoleView */;
    [SerializeField] public object m_CurrentWielderLabel /* TMPro.TextMeshProUGUI */;
}

}

