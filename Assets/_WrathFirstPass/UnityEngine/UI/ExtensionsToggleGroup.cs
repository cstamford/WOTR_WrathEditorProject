using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI {

public class ExtensionsToggleGroup {
    [SerializeField] public bool m_AllowSwitchOff /* System.Boolean */;
    public global::UnityEngine.UI.ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupChanged /* UnityEngine.UI.ToggleGroupEvent */;
    public global::UnityEngine.UI.ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupToggleChanged /* UnityEngine.UI.ToggleGroupEvent */;

    public class ToggleGroupEvent : global::UnityEngine.Events.UnityEvent {
    }

}

}

