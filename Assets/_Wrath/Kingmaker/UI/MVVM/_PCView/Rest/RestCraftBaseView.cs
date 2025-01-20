using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftBaseView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestCraftSetPCView CraftSetView /* Kingmaker.UI.MVVM._PCView.Rest.RestCraftSetPCView */;
    [SerializeField] public object m_FirstCraft /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_FirstCraftIconButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_FirstCraftButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SecondCraft /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_SecondCraftIconButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_SecondCraftButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_FirstCraftSelectedItemImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_FirstCraftSelectedItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_FirstCraftSelectedItemDesc /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_SecondCraftObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_BorderLineObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_SecondCraftSelectedItemImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_SecondCraftSelectedItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SecondCraftSelectedItemDesc /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatTypeUnitSelectionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_ChooseScrollScribingSkills /* UnityEngine.GameObject */;
}

}

