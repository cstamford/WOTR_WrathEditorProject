using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.InfoWindow {

public class InfoWindowView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public bool m_IsStartPosition /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Vector2 m_Position /* UnityEngine.Vector2 */;
}

}

