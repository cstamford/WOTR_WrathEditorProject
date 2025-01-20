using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.Tutorial {

public class TutorialBigWindowConsoleView {
    [SerializeField] public global::UnityEngine.GameObject m_PagesBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Common.PageNavigation m_PageNavigation /* Kingmaker.UI.Common.PageNavigation */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::UnityEngine.UI.LayoutElement m_ViewPort /* UnityEngine.UI.LayoutElement */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public int m_ViewPortHeight /* System.Int32 */;
    [SerializeField] public object m_CloseWindowHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_SelectPageHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NavigationParameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
}

}

