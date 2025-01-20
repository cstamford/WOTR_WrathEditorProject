using System;
using UnityEngine;

namespace Kingmaker.UI.Common.Animations {

public class MoveAnimator : global::UnityEngine.MonoBehaviour {
    public bool MoveByX /* System.Boolean */;
    public global::Kingmaker.UI.Common.Animations.MoveAnimator.MovePart MovePartX /* Kingmaker.UI.Common.Animations.MovePart */;
    public bool MoveByY /* System.Boolean */;
    public global::Kingmaker.UI.Common.Animations.MoveAnimator.MovePart MovePartY /* Kingmaker.UI.Common.Animations.MovePart */;

    public class MovePart {
        public float AppearPosition /* System.Single */;
        public float DisappearPosition /* System.Single */;
        public float AnimationTime /* System.Single */;
        public global::UnityEngine.AnimationCurve Curve /* UnityEngine.AnimationCurve */;
    }

}

}

