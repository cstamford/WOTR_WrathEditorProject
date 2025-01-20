using System;
using UnityEngine;

namespace Kingmaker.UI.Ping {

public class PingHandler : global::UnityEngine.MonoBehaviour {
    public string Key /* System.String */;
    public global::Kingmaker.UI.Ping.PingHandler.TypeEvent IncludeEvents /* Kingmaker.UI.Ping.TypeEvent */;

    public enum TypeEvent {
        Hover = 2,
        DragAndDrop = 4,
    }

}

}

