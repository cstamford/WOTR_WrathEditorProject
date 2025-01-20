using System;
using System.Collections.Generic;
using UnityEngine;

public class AkEvent {
    public object actionOnEventType /* .AkActionOnEventType */;
    public object curveInterpolation /* .AkCurveInterpolation */;
    public bool enableActionOnEvent /* System.Boolean */;
    public object data /* AK.Wwise.Event */;
    public bool useCallbacks /* System.Boolean */;
    public global::System.Collections.Generic.List<AkEvent.CallbackData> Callbacks /* System.Collections.Generic.List<.CallbackData> */;
    public uint playingId /* System.UInt32 */;
    public global::UnityEngine.GameObject soundEmitterObject /* UnityEngine.GameObject */;
    public float transitionDuration /* System.Single */;
    [SerializeField] public int eventIdInternal /* System.Int32 */;
    [SerializeField] public byte[] valueGuidInternal /* System.Byte[] */;
    [SerializeField] public AkEventCallbackData m_callbackDataInternal /* .AkEventCallbackData */;

    public class CallbackData {
        public object Flags /* AK.Wwise.CallbackFlags */;
        public string FunctionName /* System.String */;
        public global::UnityEngine.GameObject GameObject /* UnityEngine.GameObject */;
    }

}

