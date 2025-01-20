using Kingmaker.UI.Common.Animations;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Tooltip {

public class TooltipBase : global::UnityEngine.MonoBehaviour {
    public float HeightLimit /* System.Single */;
    public global::UnityEngine.GameObject Content /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.LayoutElement ContentWindowLayout /* UnityEngine.UI.LayoutElement */;
    public bool AutoPosition /* System.Boolean */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::UnityEngine.UI.HorizontalLayoutGroup LayoutGroup /* UnityEngine.UI.HorizontalLayoutGroup */;
    public float DefaultAnimationDelay /* System.Single */;
    public global::System.Collections.Generic.List<global::UnityEngine.Vector2> defaultPivots /* System.Collections.Generic.List<UnityEngine.Vector2> */;
}

}

