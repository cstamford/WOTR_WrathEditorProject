using System;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class Accordion : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Extensions.Accordion.Transition m_Transition /* UnityEngine.UI.Extensions.Transition */;
    [SerializeField] public float m_TransitionDuration /* System.Single */;

    public enum Transition {
        Instant = 0,
        Tween = 1,
    }

}

}

