using System;
using UnityEngine;
using UnityEngine.Playables;

public class AkTimelineEventPlayable {
    public object akEvent /* AK.Wwise.Event */;
    [SerializeField] public object blendInCurve /* .AkCurveInterpolation */;
    [SerializeField] public object blendOutCurve /* .AkCurveInterpolation */;
    public float eventDurationMax /* System.Single */;
    public float eventDurationMin /* System.Single */;
    [SerializeField] public bool retriggerEvent /* System.Boolean */;
    public bool UseWwiseEventDuration /* System.Boolean */;
    public bool PrintDebugInformation /* System.Boolean */;
    [SerializeField] public bool StopEventAtClipEnd /* System.Boolean */;
}

