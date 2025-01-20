using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker {

public class InitiativeTrackerUnitConsoleView : global::Kingmaker.UI.MVVM._ConsoleView.TacticalCombat.InitiativeTracker.InitiativeTrackerUnitBaseConsoleView {
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public float m_UnitSize /* System.Single */;
    [SerializeField] public float m_SizeRound /* System.Single */;
    [SerializeField] public global::UnityEngine.GameObject m_UnitGameObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_BackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.RectTransform RoundRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public object m_RoundNumberText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_FriendlyColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_EnemyColor /* UnityEngine.Color */;
    public float m_AnimationTime /* System.Single */;
    [SerializeField] public object m_DisintegrationAnimator /* Kingmaker.UI.Common.Animations.DisintegrationAnimator[] */;
}

}

