using Kingmaker.UI._ConsoleUI.TurnBasedMode;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.TurnBasedMode {

public class InitiativeTrackerUnitOrderHorizontalPCView : global::Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerUnitBaseView {
    [SerializeField] public object m_ColorAnimator /* Kingmaker.UI.Common.Animations.ColorAnimator[] */;
    [SerializeField] public object m_DesintegrationAnimator /* Kingmaker.UI.Common.Animations.DisintegrationAnimator[] */;
    [SerializeField] public object m_CharacterDesintegrationAnimator /* Kingmaker.UI.Common.Animations.DisintegrationAnimator[] */;
    [SerializeField] public object m_NPCDesintegrationAAnimator /* Kingmaker.UI.Common.Animations.DisintegrationAnimator[] */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public float m_SizeWithPortrait /* System.Single */;
    [SerializeField] public float m_SizeWithIcon /* System.Single */;
    [SerializeField] public float m_SizeRound /* System.Single */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerEndOfRound m_EndOfRound /* Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerEndOfRound */;
    [SerializeField] public global::UnityEngine.GameObject m_UnitContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_PortraitButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    public bool WillBeDestroyedExternal /* System.Boolean */;
    [SerializeField] public object m_DealyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::UnityEngine.RectTransform m_PortraitPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.Vector2 m_PortraitPlaceDelayPositionAdditive /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.RectTransform m_DelayMarker /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_DelayMarkerCanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public float m_DelayMarkerAnimationTime /* System.Single */;
    [SerializeField] public global::UnityEngine.Vector2 m_DelayMarkerFromPositionAdditive /* UnityEngine.Vector2 */;
    public float m_AnimationTime /* System.Single */;
    public float m_Sacale /* System.Single */;
}

}

