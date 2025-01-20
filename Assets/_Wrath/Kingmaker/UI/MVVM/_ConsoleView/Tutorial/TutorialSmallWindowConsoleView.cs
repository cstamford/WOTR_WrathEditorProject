using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.Tutorial {

public class TutorialSmallWindowConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public int m_ViewPortHeight /* System.Int32 */;
    [SerializeField] public global::UnityEngine.UI.LayoutElement m_ViewPort /* UnityEngine.UI.LayoutElement */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public object m_Back /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_OptionsCloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_EnterSmallTutorHintsHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Image m_ProgressBar /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ProgressHint /* UnityEngine.UI.Image */;
    [SerializeField] public float m_Offset /* System.Single */;
    [SerializeField] public object m_NavigationParameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
}

}

