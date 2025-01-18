using System;
using UnityEngine;

public class AkGameObj : MonoBehaviour {
    [SerializeField] public object m_listeners /* .AkGameObjListenerList */;
    public bool isEnvironmentAware /* System.Boolean */;
    [SerializeField] public bool isStaticObject /* System.Boolean */;
    public object m_positionOffsetData /* .AkGameObjPositionOffsetData */;
    [SerializeField] public AkGameObjPosOffsetData m_posOffsetData /* .AkGameObjPosOffsetData */;
    [SerializeField] public int listenerMask /* System.Int32 */;
}

