using System;
using UnityEngine;

namespace Kingmaker.AreaLogic.Cutscenes.Commands.Timeline {

public class DirectorCameraLink : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.DirectorCameraLink.ListenerControlType ControlAudioListenerType /* Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.ListenerControlType */;
    public global::UnityEngine.Transform AudioListenerRoot /* UnityEngine.Transform */;
    public bool KeepDefaultListenerRotation /* System.Boolean */;
    public bool ControlZoom /* System.Boolean */;
    public float Zoom /* System.Single */;

    public enum ListenerControlType {
        None = 0,
        FixedToCamera = 1,
        TimelineAnimated = 2,
    }

}

}

