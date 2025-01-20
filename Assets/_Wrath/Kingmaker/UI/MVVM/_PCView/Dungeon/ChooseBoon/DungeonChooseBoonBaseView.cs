using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Dungeon.ChooseBoon {

public class DungeonChooseBoonBaseView {
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dungeon.ChooseBoon.DungeonBoonSelectorPCView m_DungeonBoonSelectorPCView /* Kingmaker.UI.MVVM._PCView.Dungeon.ChooseBoon.DungeonBoonSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

