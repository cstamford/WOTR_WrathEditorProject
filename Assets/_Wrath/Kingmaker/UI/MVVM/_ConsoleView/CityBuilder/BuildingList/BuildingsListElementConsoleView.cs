using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.CityBuilder.BuildingList {

public class BuildingsListElementConsoleView {
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescriptionLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_BackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_SlotsImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_CanUpgradeMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_TimerObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_TimerLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomResourcesConsoleView m_Resources /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomResourcesConsoleView */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
}

}

