using System;
using System.Collections.Generic;
using UnityEngine;

public class AkEventCallbackData : ScriptableObject {
    public List<int> callbackFlags /* System.Collections.Generic.List<System.Int32> */;
    public List<string> callbackFunc /* System.Collections.Generic.List<System.String> */;
    public List<GameObject> callbackGameObj /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public int uFlags /* System.Int32 */;
}

