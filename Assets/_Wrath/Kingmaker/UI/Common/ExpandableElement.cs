using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.Common {

public class ExpandableElement : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.Transform m_ExpandArrow /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject m_Content /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_ContentAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public string Key /* System.String */;
    public string ParentKey /* System.String */;
}

}

