using Kingmaker.UI.MVVM._PCView.Crusade.Recruit;
using System;
using UnityEngine;

namespace Kingmaker.UI.Settlement {

public class SettlementToolbar : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_SettlementName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RegionName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_FinancesCount /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MaterialsCount /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_FavorsCount /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.MonoBehaviour m_FinancesTooltip /* UnityEngine.MonoBehaviour */;
    [SerializeField] public global::UnityEngine.MonoBehaviour m_MaterialsTooltip /* UnityEngine.MonoBehaviour */;
    [SerializeField] public global::UnityEngine.MonoBehaviour m_FavorsTooltip /* UnityEngine.MonoBehaviour */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesPCView m_BuyResourcesPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesPCView */;
    [SerializeField] public object m_BuyResourceButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

