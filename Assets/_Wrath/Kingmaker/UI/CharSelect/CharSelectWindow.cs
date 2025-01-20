using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.CharSelect {

public class CharSelectWindow : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_OkButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::UnityEngine.Transform m_ItemsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_BgAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.CharSelect.HeroPortraitButton m_PortraitSlectorItem /* Kingmaker.UI.CharSelect.HeroPortraitButton */;
    [SerializeField] public global::UnityEngine.UI.ToggleGroup m_ToggleGroup /* UnityEngine.UI.ToggleGroup */;
}

}

