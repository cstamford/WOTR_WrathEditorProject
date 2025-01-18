using System;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class Accordion : MonoBehaviour {
    [SerializeField] public Accordion.Transition m_Transition /* UnityEngine.UI.Extensions.Transition */;
    [SerializeField] public float m_TransitionDuration /* System.Single */;

    public enum Transition {
        Instant = 0,
        Tween = 1,
    }

}

}

