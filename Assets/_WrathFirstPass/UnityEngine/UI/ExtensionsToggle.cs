using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.UI {

public class ExtensionsToggle : global::UnityEngine.UI.Selectable {
    public global::UnityEngine.UI.ExtensionsToggle.ToggleTransition toggleTransition /* UnityEngine.UI.ToggleTransition */;
    public global::UnityEngine.UI.Graphic graphic /* UnityEngine.UI.Graphic */;
    [SerializeField] public global::UnityEngine.UI.ExtensionsToggleGroup m_Group /* UnityEngine.UI.ExtensionsToggleGroup */;
    public global::UnityEngine.UI.ExtensionsToggle.ToggleEvent onValueChanged /* UnityEngine.UI.ToggleEvent */;
    [SerializeField] public bool m_IsOn /* System.Boolean */;

    public enum ToggleTransition {
        None = 0,
        Fade = 1,
    }

    public class ToggleEvent : global::UnityEngine.Events.UnityEvent {
    }

}

}

