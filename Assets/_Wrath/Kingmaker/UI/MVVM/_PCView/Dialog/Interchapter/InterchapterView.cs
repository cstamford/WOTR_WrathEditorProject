using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.Dialog.Dialog;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Dialog.Interchapter {

public class InterchapterView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_ContentAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.UI.Image m_Picture /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_PortraitObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_PictureAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.GameObject m_InterchapterObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_TitleContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_CuesPanel /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.Dialog.DialogCueView m_CueView /* Kingmaker.UI.MVVM._PCView.Dialog.Dialog.DialogCueView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_AnswersPanel /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.Dialog.DialogAnswerView m_AnswerView /* Kingmaker.UI.MVVM._PCView.Dialog.Dialog.DialogAnswerView */;
    [SerializeField] public global::UnityEngine.GameObject m_InterchapterBackground /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_EpilogueBackground /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public int m_InterchapterWidth /* System.Int32 */;
    [SerializeField] public int m_EpilogueWidth /* System.Int32 */;
    [SerializeField] public int m_CuesMaxHeight /* System.Int32 */;
    [SerializeField] public global::UnityEngine.UI.LayoutElement m_CuesBlock /* UnityEngine.UI.LayoutElement */;
}

}

