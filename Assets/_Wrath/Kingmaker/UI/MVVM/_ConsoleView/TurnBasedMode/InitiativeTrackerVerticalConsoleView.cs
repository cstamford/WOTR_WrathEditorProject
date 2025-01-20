using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.TurnBasedMode;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode {

public class InitiativeTrackerVerticalConsoleView : global::Kingmaker.UI.TurnBasedMode.InitiativeTrackerBaseView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode.InitiativeTrackerCurrentUnitVerticalConsoleView m_CurrentUnitView /* Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode.InitiativeTrackerCurrentUnitVerticalConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode.InitiativeTrackerUnitVerticalConsoleView m_UnitPrefab /* Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode.InitiativeTrackerUnitVerticalConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_InitiativeTrackerAnimation /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::UnityEngine.RectTransform m_TrackerContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_OrderContainer /* UnityEngine.RectTransform */;
    [SerializeField] public object m_HideNavigation /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_DelayHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
    public object IsControlActive /* UniRx.BoolReactiveProperty */;
}

}

