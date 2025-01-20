using System;
using UnityEngine;
using UnityEngine.Playables;

public class AkEventPlayable {
    public object akEvent /* AK.Wwise.Event */;
    [SerializeField] public object blendInCurve /* .AkCurveInterpolation */;
    [SerializeField] public object blendOutCurve /* .AkCurveInterpolation */;
    [SerializeField] public global::UnityEngine.ExposedReference<global::UnityEngine.GameObject> emitterObjectRef /* UnityEngine.ExposedReference<UnityEngine.GameObject> */;
    public float eventDurationMax /* System.Single */;
    public float eventDurationMin /* System.Single */;
    [SerializeField] public bool retriggerEvent /* System.Boolean */;
    public bool UseWwiseEventDuration /* System.Boolean */;
    [SerializeField] public bool StopEventAtClipEnd /* System.Boolean */;
}

