using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker {

public class InitiativeTrackerUnitBaseConsoleView {
    [SerializeField] public object m_FocusButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_ArrowsButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_UnitNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerPortraitZone m_PortraitZone /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerPortraitZone */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_BuffWidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerBuffPCView m_BuffViewPrefab /* Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerBuffPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_OverlookingArrow /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_EnemyMarker /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_HoldIcon /* UnityEngine.GameObject */;
    [SerializeField] public object m_UnitCountText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_ForegroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color m_FriendlyTextColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_FriendlyForegroundColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_FriendlyTextOutline /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ControlledFriendlyTextColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ControlledFriendlyForegroundColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ControlledFriendlyTextOutline /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_EnemyTextColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_EnemyForegroundColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_EnemyTextOutline /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ControlledEnemyTextColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ControlledEnemyForegroundColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ControlledEnemyTextOutline /* UnityEngine.Color */;
    [SerializeField] public int MaxBuffs /* System.Int32 */;
    public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
}

}

