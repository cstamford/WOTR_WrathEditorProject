using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Loot {

public class LootConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Loot.LootCollectorConsoleView m_Collector /* Kingmaker.UI.MVVM._ConsoleView.Loot.LootCollectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Loot.LootInventoryStashConsoleView m_Inventory /* Kingmaker.UI.MVVM._ConsoleView.Loot.LootInventoryStashConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Loot.InteractionSlotPartConsoleView m_InteractionSlotPart /* Kingmaker.UI.MVVM._ConsoleView.Loot.InteractionSlotPartConsoleView */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_RemoveLootToggle /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_RemoveLootText /* TMPro.TextMeshProUGUI */;
}

}

