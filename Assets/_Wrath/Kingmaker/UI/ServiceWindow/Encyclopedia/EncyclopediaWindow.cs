using Kingmaker.Blueprints.Encyclopedia;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia;
using Kingmaker.UI.ServiceWindow;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.Encyclopedia {

public class EncyclopediaWindow {
    [SerializeField] public global::Kingmaker.Blueprints.Encyclopedia.ChapterList m_ChapterList /* Kingmaker.Blueprints.Encyclopedia.ChapterList */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Encyclopedia.HierarchyView m_Hierarchy /* Kingmaker.UI.ServiceWindow.Encyclopedia.HierarchyView */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Encyclopedia.PageView m_Page /* Kingmaker.UI.ServiceWindow.Encyclopedia.PageView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.BreadcrumbsComponent m_Path /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.BreadcrumbsComponent */;
    [SerializeField] public global::UnityEngine.UI.Selectable m_PreviusButton /* UnityEngine.UI.Selectable */;
    [SerializeField] public global::UnityEngine.UI.Selectable m_NextButton /* UnityEngine.UI.Selectable */;
}

}

