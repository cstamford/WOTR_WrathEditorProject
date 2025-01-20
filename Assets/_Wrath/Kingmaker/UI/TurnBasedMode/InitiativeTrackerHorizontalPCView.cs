using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.Constructor;
using System;
using UnityEngine;

namespace Kingmaker.UI.TurnBasedMode {

public class InitiativeTrackerHorizontalPCView : global::Kingmaker.UI.TurnBasedMode.InitiativeTrackerBaseView {
    [SerializeField] public global::Kingmaker.UI.TurnBasedMode.InitiativeTrackerCurrentUnitPCView m_CurrentUnit /* Kingmaker.UI.TurnBasedMode.InitiativeTrackerCurrentUnitPCView */;
    [SerializeField] public float m_WaitHoldedUnitTime /* System.Single */;
    [SerializeField] public global::UnityEngine.GameObject m_ScrollArrow /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.TurnBasedMode.InitiativeTrackerUnitOrderHorizontalPCView m_UnitPrefab /* Kingmaker.UI.TurnBasedMode.InitiativeTrackerUnitOrderHorizontalPCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_TrackerContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_CurrentUnitContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_OrderContainer /* UnityEngine.RectTransform */;
    [SerializeField] public float m_LeftRightPadding /* System.Single */;
    [SerializeField] public global::UnityEngine.RectTransform m_RightScrollMarker /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_LeftScrollMarker /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_ScrollRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_OwnAnimation /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.MonoBehaviour m_TooltipPlace /* UnityEngine.MonoBehaviour */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeBack /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_DelayBackButton /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_DelayButton /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_DelayButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DelayNotificationText /* TMPro.TextMeshProUGUI */;
}

}

