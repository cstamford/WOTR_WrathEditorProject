using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom.Navigation {

public class KingdomNavigationConsoleView {
    [SerializeField] public global::UnityEngine.RectTransform m_SectionsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Navigation.KingdomNavigationProjectTypeConsoleView m_ProjectTypeSelector /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Navigation.KingdomNavigationProjectTypeConsoleView */;
    [SerializeField] public global::UnityEngine.RectTransform m_RectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public int m_ShowPosY /* System.Int32 */;
    [SerializeField] public int m_HidePosY /* System.Int32 */;
    [SerializeField] public object m_PrevHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    public object CurrentKingdomNavigationTypeConsole /* UniRx.ReactiveProperty */;
}

}

