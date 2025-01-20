using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Crusade.Recruit {

public class RecruitShopUnitView : global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitUnitView {
    [SerializeField] public object m_GrowthLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_GrowthContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitResourcePriceView m_PriceView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitResourcePriceView */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_Canvas /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.UI.Image m_NotRerollableObject /* UnityEngine.UI.Image */;
}

}

