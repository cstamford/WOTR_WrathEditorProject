using Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Toolbar {

public class CityBuilderToolbarConsoleView {
    [SerializeField] public object m_SettlementName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RegionName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomResourcesConsoleView m_ResourcesConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomResourcesConsoleView */;
    [SerializeField] public object m_BuyLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit.RecruitBuyResourcesConsoleView m_BuyResourcesConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit.RecruitBuyResourcesConsoleView */;
    [SerializeField] public object m_BuyResourcesHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

