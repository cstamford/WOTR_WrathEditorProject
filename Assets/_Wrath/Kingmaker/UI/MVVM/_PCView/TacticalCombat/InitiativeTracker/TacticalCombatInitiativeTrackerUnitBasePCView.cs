using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker {

public class TacticalCombatInitiativeTrackerUnitBasePCView {
    [SerializeField] public global::UnityEngine.GameObject m_UnitGameObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_BackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_PortraitImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_UnitNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_EnemyColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_FriendlyColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.UI.Image m_ForegroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_CountText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_BuffWidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerBuffPCView m_BuffViewPrefab /* Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerBuffPCView */;
    [SerializeField] public int MaxBuffs /* System.Int32 */;
    [SerializeField] public global::UnityEngine.GameObject m_OverlookingArrow /* UnityEngine.GameObject */;
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
    [SerializeField] public global::UnityEngine.RectTransform RoundRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public object m_RoundNumberText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_RoundNumberBackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_RoundDividerImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_PortraitButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

