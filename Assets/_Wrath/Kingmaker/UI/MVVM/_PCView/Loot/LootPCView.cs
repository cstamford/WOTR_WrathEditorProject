using Kingmaker.Assets.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Loot {

public class LootPCView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.Assets.UI.Common.DraggbleWindow m_DraggbleWindow /* Kingmaker.Assets.UI.Common.DraggbleWindow */;
    [SerializeField] public global::UnityEngine.Vector2 m_InitPosition /* UnityEngine.Vector2 */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Loot.LootCollectorPCView m_Collector /* Kingmaker.UI.MVVM._PCView.Loot.LootCollectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Loot.LootInventoryStashPCView m_Inventory /* Kingmaker.UI.MVVM._PCView.Loot.LootInventoryStashPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Loot.InteractionSlotPartPCView m_InteractionSlot /* Kingmaker.UI.MVVM._PCView.Loot.InteractionSlotPartPCView */;
    [SerializeField] public object m_Close /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RemoveLootToggle /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_RemoveLootText /* TMPro.TextMeshProUGUI */;
}

}

