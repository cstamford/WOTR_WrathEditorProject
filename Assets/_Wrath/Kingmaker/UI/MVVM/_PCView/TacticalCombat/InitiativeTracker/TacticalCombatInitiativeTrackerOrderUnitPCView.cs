using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker {

public class TacticalCombatInitiativeTrackerOrderUnitPCView : global::Kingmaker.UI.MVVM._PCView.TacticalCombat.InitiativeTracker.TacticalCombatInitiativeTrackerUnitBasePCView {
    [SerializeField] public object m_ColorAnimator /* Kingmaker.UI.Common.Animations.ColorAnimator[] */;
    [SerializeField] public object m_DisintegrationAnimator /* Kingmaker.UI.Common.Animations.DisintegrationAnimator[] */;
    [SerializeField] public global::UnityEngine.Sprite m_FriendlyFrameSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_EnemyFrameSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.UI.Image m_FrameImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public float m_UnitSize /* System.Single */;
    [SerializeField] public float m_SizeRound /* System.Single */;
    public float m_AnimationTime /* System.Single */;
}

}

