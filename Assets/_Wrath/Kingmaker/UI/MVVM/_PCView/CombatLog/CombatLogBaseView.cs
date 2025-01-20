using Kingmaker.UI.Common.Animations;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CombatLog {

public class CombatLogBaseView {
    [SerializeField] public object m_VirtualList /* Owlcat.Runtime.UI.VirtualListSystem.VirtualListVertical */;
    [SerializeField] public global::UnityEngine.RectTransform m_RectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.GameObject m_Panel /* UnityEngine.GameObject */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.UI.Toggle> m_Toggles /* System.Collections.Generic.List<UnityEngine.UI.Toggle> */;
    [SerializeField] public object m_ToggleTexts /* System.Collections.Generic.List */;
    [SerializeField] public global::UnityEngine.UI.ToggleGroup m_ToggleGroup /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public global::UnityEngine.Color m_SelectedToggleTextColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_DefaultToggleTextColor /* UnityEngine.Color */;
}

}

