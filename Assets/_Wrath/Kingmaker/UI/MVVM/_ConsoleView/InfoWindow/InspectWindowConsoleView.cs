using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.InfoWindow {

public class InspectWindowConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.InfoWindow.InspectInfoWindowConsoleView m_InfoWindow /* Kingmaker.UI.MVVM._ConsoleView.InfoWindow.InspectInfoWindowConsoleView */;
    [SerializeField] public object m_UnitWindowHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_UnitsContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.InfoWindow.InspectUnitView m_UnitView /* Kingmaker.UI.MVVM._ConsoleView.InfoWindow.InspectUnitView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_InfoWindowScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_UnitsScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
}

}

