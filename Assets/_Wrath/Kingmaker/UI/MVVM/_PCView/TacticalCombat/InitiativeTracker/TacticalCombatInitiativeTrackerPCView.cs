using Kingmaker.UI._ConsoleUI.TurnBasedMode;
using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.Constructor;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker {

public class TacticalCombatInitiativeTrackerPCView {
    [SerializeField] public global::UnityEngine.UI.Image m_TooltipPlace /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerUnitBasePCView m_CurrentUnitView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerUnitBasePCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_CurrentUnitContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_TrackerContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.HorizontalLayoutGroup m_TrackerHorizontalLayoutGroup /* UnityEngine.UI.HorizontalLayoutGroup */;
    [SerializeField] public global::UnityEngine.RectTransform m_OrderContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_InitiativeTrackerAnimation /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerOrderUnitPCView m_UnitPrefab /* Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerOrderUnitPCView */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.TurnVirtualListController m_VirtualListController /* Kingmaker.UI._ConsoleUI.TurnBasedMode.TurnVirtualListController */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_LeftButton /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_RightButton /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::UnityEngine.RectTransform m_RightScrollMarker /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_LeftScrollMarker /* UnityEngine.RectTransform */;
}

}

