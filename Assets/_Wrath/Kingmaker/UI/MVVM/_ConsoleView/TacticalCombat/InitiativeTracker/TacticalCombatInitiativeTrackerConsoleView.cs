using Kingmaker.UI._ConsoleUI.TurnBasedMode;
using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker {

public class TacticalCombatInitiativeTrackerConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerCurrentUnitConsoleView m_CurrentUnitView /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerCurrentUnitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerUnitConsoleView m_UnitPrefab /* Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerUnitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_InitiativeTrackerAnimation /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::UnityEngine.RectTransform m_TrackerContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.TurnVirtualListController m_VirtualListController /* Kingmaker.UI._ConsoleUI.TurnBasedMode.TurnVirtualListController */;
    [SerializeField] public global::UnityEngine.RectTransform m_OrderContainer /* UnityEngine.RectTransform */;
    [SerializeField] public object m_HideNavigation /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
}

}

