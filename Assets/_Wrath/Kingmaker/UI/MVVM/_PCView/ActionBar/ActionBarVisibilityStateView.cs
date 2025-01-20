using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarVisibilityStateView {
    [SerializeField] public object m_SwitchTbmPartyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.RectTransform m_ActionBarMainContainer /* UnityEngine.RectTransform */;
    [SerializeField] public int m_ActionBarMainPartyShowed /* System.Int32 */;
    [SerializeField] public int m_ActionBarMainPartyHidden /* System.Int32 */;
    [SerializeField] public global::UnityEngine.RectTransform m_CornersContainer /* UnityEngine.RectTransform */;
    [SerializeField] public int m_CornersPartyShowed /* System.Int32 */;
    [SerializeField] public int m_CornersPartyHidden /* System.Int32 */;
    [SerializeField] public int m_CornersAllHidden /* System.Int32 */;
    [SerializeField] public global::UnityEngine.RectTransform m_ControlCharacterView /* UnityEngine.RectTransform */;
    [SerializeField] public int m_ControlCharacterPartyShowed /* System.Int32 */;
    [SerializeField] public int m_ControlCharacterPartyHidden /* System.Int32 */;
    [SerializeField] public int m_ControlCharacterAllHidden /* System.Int32 */;
    [SerializeField] public object m_LeftSwitchButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.RectTransform m_LeftSide /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_LeftFadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public int m_LeftHiddenPosX /* System.Int32 */;
    [SerializeField] public int m_LeftPhase0PosX /* System.Int32 */;
    [SerializeField] public int m_LeftPhase1PosX /* System.Int32 */;
    [SerializeField] public int m_LeftPhase2PosX /* System.Int32 */;
    [SerializeField] public global::UnityEngine.GameObject m_LeftSideSlotsContainer /* UnityEngine.GameObject */;
}

}

