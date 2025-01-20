using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events {

public class KingdomEventsContainerConsoleView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventConsoleView m_EventPrefab /* Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventConsoleView */;
    [SerializeField] public float m_Radius /* System.Single */;
    [SerializeField] public float m_OffsetY /* System.Single */;
    [SerializeField] public float m_HoverOffset /* System.Single */;
    [SerializeField] public float m_HoverDeltaAngle /* System.Single */;
    [SerializeField] public int m_SortOrderSelected /* System.Int32 */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventConsoleView> Events /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events.KingdomEventConsoleView> */;
}

}

