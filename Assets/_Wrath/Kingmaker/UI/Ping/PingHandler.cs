using System;
using UnityEngine;

namespace Kingmaker.UI.Ping {

public class PingHandler : MonoBehaviour {
    public string Key /* System.String */;
    public PingHandler.TypeEvent IncludeEvents /* Kingmaker.UI.Ping.TypeEvent */;

    public enum TypeEvent {
        Hover = 2,
        DragAndDrop = 4,
    }

}

}

