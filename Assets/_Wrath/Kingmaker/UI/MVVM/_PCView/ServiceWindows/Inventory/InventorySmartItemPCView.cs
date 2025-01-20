using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory {

public class InventorySmartItemPCView {
    [SerializeField] public object m_TitleLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_UnitPortrait /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StartDialogButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_StartDialogButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Dropdown /* TMPro.TMP_Dropdown */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.SmartItemSlotPCView m_SmartItemSlotView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.SmartItemSlotPCView */;
    [SerializeField] public object m_CurrentWielderLabel /* TMPro.TextMeshProUGUI */;
}

}

