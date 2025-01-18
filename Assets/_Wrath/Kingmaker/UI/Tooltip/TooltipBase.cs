using Kingmaker.UI.Common.Animations;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Tooltip {

public class TooltipBase : MonoBehaviour {
    public float HeightLimit /* System.Single */;
    public GameObject Content /* UnityEngine.GameObject */;
    public LayoutElement ContentWindowLayout /* UnityEngine.UI.LayoutElement */;
    public bool AutoPosition /* System.Boolean */;
    public FadeAnimator Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public HorizontalLayoutGroup LayoutGroup /* UnityEngine.UI.HorizontalLayoutGroup */;
    public float DefaultAnimationDelay /* System.Single */;
    public List<Vector2> defaultPivots /* System.Collections.Generic.List<UnityEngine.Vector2> */;
}

}

