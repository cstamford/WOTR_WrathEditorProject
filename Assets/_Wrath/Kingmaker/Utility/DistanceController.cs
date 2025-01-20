using System;
using UnityEngine;
using UnityEngine.Events;

namespace Kingmaker.Utility {

public class DistanceController : global::UnityEngine.MonoBehaviour {
    public float range /* System.Single */;
    public global::UnityEngine.Events.UnityEvent m_OnDistanceExceeded /* UnityEngine.Events.UnityEvent */;
    public global::UnityEngine.Events.UnityEvent m_OnAfterOneFrame /* UnityEngine.Events.UnityEvent */;
}

}

