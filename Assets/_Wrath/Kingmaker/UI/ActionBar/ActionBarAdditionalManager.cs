using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ActionBar {

public class ActionBarAdditionalManager : MonoBehaviour {
    public RectTransform Slots /* UnityEngine.RectTransform */;
    public Image ArrowUp /* UnityEngine.UI.Image */;
    public Image ArrowDown /* UnityEngine.UI.Image */;
    public float HidePosX /* System.Single */;
    public float Phase0PosX /* System.Single */;
    public float Phase1PosX /* System.Single */;
    public float Phase2PosX /* System.Single */;
    [SerializeField] public FadeAnimator m_Fade /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

