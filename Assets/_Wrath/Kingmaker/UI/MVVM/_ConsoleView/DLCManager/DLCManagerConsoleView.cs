using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.DLCManager {

public class DLCManagerConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.DLCManager.DLCEntityConsoleView m_DLCEntityConsoleViewPrefab /* Kingmaker.UI.MVVM._ConsoleView.DLCManager.DLCEntityConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
}

}

