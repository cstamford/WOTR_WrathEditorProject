using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftRecipeBaseView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestCasterLevelBaseView m_CasterLevelView /* Kingmaker.UI.MVVM._PCView.Rest.RestCasterLevelBaseView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestCraftSetPCView CraftSetView /* Kingmaker.UI.MVVM._PCView.Rest.RestCraftSetPCView */;
    [SerializeField] public global::UnityEngine.UI.Image m_SelectedItemImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_SelectedItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SelectedItemDesc /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RollText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DCText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SuccessChanceText /* TMPro.TextMeshProUGUI */;
}

}

