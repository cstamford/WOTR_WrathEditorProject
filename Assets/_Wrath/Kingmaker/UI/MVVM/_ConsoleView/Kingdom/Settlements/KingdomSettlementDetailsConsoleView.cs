using Kingmaker.UI.MVVM._ConsoleView.CityBuilder.BuildingList;
using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements.RecruitsGrowth;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements {

public class KingdomSettlementDetailsConsoleView {
    [SerializeField] public object m_SettlementTypeText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SettlementNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_UpdateMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_UpdateInfoObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_UpdateInfoLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CityBuilder.BuildingList.BuildingsListConsoleView m_BuildingsListView /* Kingmaker.UI.MVVM._ConsoleView.CityBuilder.BuildingList.BuildingsListConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements.RecruitsGrowth.RecruitsGrowthListConsoleView m_RecruitsGrowthListView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Settlements.RecruitsGrowth.RecruitsGrowthListConsoleView */;
    [SerializeField] public object m_BuildingsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
}

}

