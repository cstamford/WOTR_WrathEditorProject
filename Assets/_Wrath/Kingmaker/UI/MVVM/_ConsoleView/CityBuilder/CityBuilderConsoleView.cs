using Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Navigation;
using Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Toolbar;
using Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CityBuilder {

public class CityBuilderConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Toolbar.CityBuilderToolbarConsoleView m_ToolbarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Toolbar.CityBuilderToolbarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomInfoConsoleView m_KingdomInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GlobalMap.KingdomInfo.KingdomInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Navigation.CityBuilderNavigationConsoleView m_NavigationConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CityBuilder.Navigation.CityBuilderNavigationConsoleView */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.MonoBehaviour> m_UIElements /* System.Collections.Generic.List<UnityEngine.MonoBehaviour> */;
}

}

