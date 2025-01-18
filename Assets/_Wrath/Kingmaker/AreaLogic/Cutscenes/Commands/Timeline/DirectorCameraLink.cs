using System;
using UnityEngine;

namespace Kingmaker.AreaLogic.Cutscenes.Commands.Timeline {

public class DirectorCameraLink : MonoBehaviour {
    public DirectorCameraLink.ListenerControlType ControlAudioListenerType /* Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.ListenerControlType */;
    public Transform AudioListenerRoot /* UnityEngine.Transform */;
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

