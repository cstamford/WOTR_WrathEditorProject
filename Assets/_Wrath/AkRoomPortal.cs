using System;
using System.Collections.Generic;
using UnityEngine;

public class AkRoomPortal {
    public AkRoomPortal.State initialState /* .State */;
    public global::System.Collections.Generic.List<int> closePortalTriggerList /* System.Collections.Generic.List<System.Int32> */;
    [SerializeField] public object rooms /* .AkRoom[] */;

    public enum State {
        Closed = 0,
        Open = 1,
    }

}

