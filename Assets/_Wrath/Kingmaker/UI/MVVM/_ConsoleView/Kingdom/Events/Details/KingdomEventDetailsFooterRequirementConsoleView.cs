using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.Details {

public class KingdomEventDetailsFooterRequirementConsoleView {
    [SerializeField] public object m_RequiredLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomStatSimpleConsoleView m_StatView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomStatSimpleConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomResourcesConsoleView m_ResourcesView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomResourcesConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_NotEnoughObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_NotEnoughResourcesLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NoLeaderAvailableLabel /* TMPro.TextMeshProUGUI */;
}

}

