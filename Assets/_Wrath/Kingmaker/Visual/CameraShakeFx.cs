using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class CameraShakeFx : MonoBehaviour {
    public AnimationCurve DeltaX /* UnityEngine.AnimationCurve */;
    public AnimationCurve DeltaY /* UnityEngine.AnimationCurve */;
    public AnimationCurve AmplitudeOverLifetime /* UnityEngine.AnimationCurve */;
    public AnimationCurve FreqOverLifetime /* UnityEngine.AnimationCurve */;
    public AnimationCurve AmplitudeOverDistance /* UnityEngine.AnimationCurve */;
    public AnimationCurve FreqOverDistance /* UnityEngine.AnimationCurve */;
    public bool ShakeAnchor /* System.Boolean */;
    public float AmplitudeMultiplier /* System.Single */;
    public float FreqMultiplier /* System.Single */;
    public bool InvertXRandomly /* System.Boolean */;
    public bool InvertYRandomly /* System.Boolean */;
    public float Delay /* System.Single */;
}

}

