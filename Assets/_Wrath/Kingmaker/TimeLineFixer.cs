using System;
using UnityEngine;

namespace Kingmaker {

public class TimeLineFixer : global::Kingmaker.TimelineHandler {
    public bool Generate /* System.Boolean */;
    [SerializeField] public global::UnityEngine.GameObject[] m_ActivateForRun /* UnityEngine.GameObject[] */;
    [SerializeField] public object m_TimeActivators /* Kingmaker.TimeActivator[] */;

    public class TimeActivator {
        public bool active /* System.Boolean */;
        public double time /* System.Double */;
        public global::UnityEngine.GameObject obj /* UnityEngine.GameObject */;
    }

}

}

