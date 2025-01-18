using System;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class SoftMaskScript : MonoBehaviour {
    public RectTransform MaskArea /* UnityEngine.RectTransform */;
    public RectTransform maskScalingRect /* UnityEngine.RectTransform */;
    public Texture AlphaMask /* UnityEngine.Texture */;
    public float CutOff /* System.Single */;
    public bool HardBlend /* System.Boolean */;
    public bool FlipAlphaMask /* System.Boolean */;
    public bool DontClipMaskScalingRect /* System.Boolean */;
    public bool CascadeToALLChildren /* System.Boolean */;
}

}

