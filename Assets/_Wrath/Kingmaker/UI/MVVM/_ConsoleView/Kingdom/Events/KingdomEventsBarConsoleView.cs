using Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.Details;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events {

public class KingdomEventsBarConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsContainerConsoleView m_AvailableKingdomEvents /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsContainerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsContainerConsoleView m_ActiveKingdomEvents /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsContainerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsContainerConsoleView m_CompleteKingdomEvents /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventsContainerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.Details.KingdomEventDetailsConsoleView m_KingdomEventDetailsView /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.Details.KingdomEventDetailsConsoleView */;
    [SerializeField] public object m_HintLeft /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintRight /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.RectTransform m_RectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public int m_ShowPosY /* System.Int32 */;
    [SerializeField] public int m_HidePosY /* System.Int32 */;
}

}

