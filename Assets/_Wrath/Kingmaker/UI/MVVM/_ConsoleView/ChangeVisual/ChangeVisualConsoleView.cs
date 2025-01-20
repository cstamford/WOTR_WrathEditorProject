using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ChangeVisual {

public class ChangeVisualConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryDollConsoleView m_DollView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryDollConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualInventoryStashConsoleView m_Inventory /* Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualInventoryStashConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualSecondaryItemsConsoleView m_SecondaryItemsView /* Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualSecondaryItemsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualSlotConsoleView m_PrimarySlot /* Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualSlotConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualSlotConsoleView m_SecondarySlot /* Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualSlotConsoleView */;
    [SerializeField] public object m_ChangeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ActionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SourceItemText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TargetItemText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
}

}

