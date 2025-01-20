using Kingmaker.UI.MVVM._PCView.ServiceWindows.LocalMap;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.LocalMap {

public class LocalMapConsoleView : global::Kingmaker.UI.MVVM._PCView.ServiceWindows.LocalMap.LocalMapBaseView {
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public float m_Factor /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_TimeAndDateText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ToggleModeHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

