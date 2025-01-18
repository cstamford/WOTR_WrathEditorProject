using System;
using UnityEngine;
using UnityEngine.Events;

namespace Kingmaker.Utility {

public class DistanceController : MonoBehaviour {
    public float range /* System.Single */;
    public UnityEvent m_OnDistanceExceeded /* UnityEngine.Events.UnityEvent */;
    public UnityEvent m_OnAfterOneFrame /* UnityEngine.Events.UnityEvent */;
}

}

