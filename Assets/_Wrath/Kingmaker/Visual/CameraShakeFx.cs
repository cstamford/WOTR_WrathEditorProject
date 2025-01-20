using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class CameraShakeFx : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.AnimationCurve DeltaX /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.AnimationCurve DeltaY /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.AnimationCurve AmplitudeOverLifetime /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.AnimationCurve FreqOverLifetime /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.AnimationCurve AmplitudeOverDistance /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.AnimationCurve FreqOverDistance /* UnityEngine.AnimationCurve */;
    public bool ShakeAnchor /* System.Boolean */;
    public float AmplitudeMultiplier /* System.Single */;
    public float FreqMultiplier /* System.Single */;
    public bool InvertXRandomly /* System.Boolean */;
    public bool InvertYRandomly /* System.Boolean */;
    public float Delay /* System.Single */;
}

}

