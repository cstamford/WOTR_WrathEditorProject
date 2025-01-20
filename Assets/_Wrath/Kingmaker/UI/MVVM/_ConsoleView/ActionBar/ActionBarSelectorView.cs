using Kingmaker.UI.MVVM._PCView.InfoWindow;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ActionBar {

public class ActionBarSelectorView {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_VirtualList /* Owlcat.Runtime.UI.VirtualListSystem.VirtualListVertical */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ActionBar.ActionBarSelectorItemView m_ActionBarSelectorItemView /* Kingmaker.UI.MVVM._ConsoleView.ActionBar.ActionBarSelectorItemView */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_CanvasSortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
}

}

