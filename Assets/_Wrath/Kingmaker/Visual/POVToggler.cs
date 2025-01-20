using System;
using UnityEngine;
using UnityEngine.Events;

namespace Kingmaker.Visual {

public class POVToggler {
    [SerializeField] public global::UnityEngine.Vector3 m_Normal /* UnityEngine.Vector3 */;
    [SerializeField] public float m_Threshold /* System.Single */;
    [SerializeField] public bool m_ThresholdFlip /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Events.UnityEvent<bool> m_Change /* UnityEngine.Events.UnityEvent<System.Boolean> */;
}

}

