using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.GroupChanger {

public class GroupChangerConsoleView {
    [SerializeField] public object m_PartyHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RemoteHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GroupChanger.GroupChangerCharacterConsoleView m_CharacterView /* Kingmaker.UI.MVVM._ConsoleView.GroupChanger.GroupChangerCharacterConsoleView */;
    [SerializeField] public global::UnityEngine.RectTransform m_PartyContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_RemoteContainer /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_Parameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
}

}

