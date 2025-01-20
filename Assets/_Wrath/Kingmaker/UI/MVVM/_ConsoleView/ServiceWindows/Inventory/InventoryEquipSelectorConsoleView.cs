using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory {

public class InventoryEquipSelectorConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.EquipSelectorConsoleView m_SelectorWindow /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.EquipSelectorConsoleView */;
    [SerializeField] public object m_NoItemsText /* TMPro.TextMeshProUGUI */;
}

}

