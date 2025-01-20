using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarVisibilityStateBaseView {
    [SerializeField] public global::UnityEngine.RectTransform m_ActionBarContainer /* UnityEngine.RectTransform */;
    [SerializeField] public int m_ActionBarContainerShowed /* System.Int32 */;
    [SerializeField] public int m_ActionBarContainerHidden /* System.Int32 */;
    [SerializeField] public global::UnityEngine.RectTransform m_PredictionPanelContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_PredictionPanelFadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public int m_PredictionPanelShowed /* System.Int32 */;
    [SerializeField] public int m_PredictionPanelHidden /* System.Int32 */;
    [SerializeField] public global::UnityEngine.RectTransform m_AbilitiesGroupContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_AbilitiesFadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public int m_AbilitiesGroupShowed /* System.Int32 */;
    [SerializeField] public int m_AbilitiesGroupHidden /* System.Int32 */;
    [SerializeField] public int m_AbilitiesGroupShowedWithPrediction /* System.Int32 */;
    [SerializeField] public int m_AbilitiesGroupHiddenWithPrediction /* System.Int32 */;
}

}

