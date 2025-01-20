using System;
using UnityEngine;

namespace Kingmaker.UI.Common.Animations {

public class SizeAnimator : global::UnityEngine.MonoBehaviour {
    public bool SizeByX /* System.Boolean */;
    public global::Kingmaker.UI.Common.Animations.SizeAnimator.MovePart PartX /* Kingmaker.UI.Common.Animations.MovePart */;
    public bool SizeByY /* System.Boolean */;
    public global::Kingmaker.UI.Common.Animations.SizeAnimator.MovePart PartY /* Kingmaker.UI.Common.Animations.MovePart */;
    public float AnimationTime /* System.Single */;
    public global::UnityEngine.AnimationCurve Curve /* UnityEngine.AnimationCurve */;

    public class MovePart {
        public float AppearSize /* System.Single */;
        public float DisappearSize /* System.Single */;
    }

}

}

