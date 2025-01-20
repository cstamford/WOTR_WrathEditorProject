using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._CommonView.GlobalMap.KingdomReserve;
using Kingmaker.UI.MVVM._PCView.Crusade.Recruit;
using Kingmaker.UI.MVVM._PCView.GlobalMap.KingdomMorale;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo {

public class KingdomInfoView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GlobalMap.KingdomMorale.GlobalMapKingdomMoraleView m_MoraleView /* Kingmaker.UI.MVVM._PCView.GlobalMap.KingdomMorale.GlobalMapKingdomMoraleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._CommonView.GlobalMap.KingdomReserve.GlobalMapKingdomReserveBaseView m_ReserveView /* Kingmaker.UI.MVVM._CommonView.GlobalMap.KingdomReserve.GlobalMapKingdomReserveBaseView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomStatsView m_StatsView /* Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomStatsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomResourcesView m_ResourcesView /* Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo.KingdomResourcesView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesView m_BuyResourcesView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesView */;
}

}

