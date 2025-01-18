using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.Overtip {

public class OvertipComponent : MonoBehaviour {
    [SerializeField] public FadeAnimator FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public object OvertipController /* Kingmaker.UI.Overtip.OvertipController */;
    public bool IsShowed /* System.Boolean */;
}

}

