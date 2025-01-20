using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Loot {

public class InteractionSlotPartView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Loot.LootSlotView m_SlotView /* Kingmaker.UI.MVVM._PCView.Loot.LootSlotView */;
}

}

