using Kingmaker.UI._ConsoleUI.TurnBasedMode;
using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode {

public class InitiativeTrackerUnitBaseConsoleView {
    [SerializeField] public object m_FocusButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_ArrowsButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_UnitNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerPortraitZone m_PortraitZone /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerPortraitZone */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_BuffWidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerBuffView m_BuffViewPrefab /* Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerBuffView */;
    [SerializeField] public global::UnityEngine.GameObject m_OverlookingArrow /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_EnemyMarker /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_HoldIcon /* UnityEngine.GameObject */;
    [SerializeField] public int MaxBuffs /* System.Int32 */;
    public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
}

}

