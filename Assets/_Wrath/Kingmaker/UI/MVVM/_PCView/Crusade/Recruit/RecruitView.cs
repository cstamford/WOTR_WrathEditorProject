using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Crusade.Recruit {

public class RecruitView {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBlockView m_BlockView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBlockView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoArmyCartView m_ArmyView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoArmyCartView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyCartSetLeaderView m_LeaderSetView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyCartSetLeaderView */;
    [SerializeField] public object m_CreateArmyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ResourceHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView m_FinanceView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView m_MaterialView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView m_DivineFavorView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView */;
    [SerializeField] public global::UnityEngine.RectTransform m_ShopContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitShopUnitView m_UnitView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitShopUnitView */;
    [SerializeField] public global::UnityEngine.RectTransform m_MercContainer /* UnityEngine.RectTransform */;
    [SerializeField] public object m_MercHeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MercRerollButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_MercRerollText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.LayoutElement m_MercShopLayout /* UnityEngine.UI.LayoutElement */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_MercContainerCanvas /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_MercUpButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_MercDownButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public float m_Merc01PhaseHeight /* System.Single */;
    [SerializeField] public float m_Merc02PhaseHeight /* System.Single */;
    [SerializeField] public float m_Merc03PhaseHeight /* System.Single */;
    [SerializeField] public object m_MercFreeRerollText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MercPriceRerollText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView m_MercRerollFinanceView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBaseResourceView */;
    [SerializeField] public global::UnityEngine.UI.Slider m_MercLoadingSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesView m_BuyResourcesView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesView */;
    [SerializeField] public object m_BuyResourceLabel /* TMPro.TextMeshProUGUI */;
}

}

