using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class UIScrollToSelection : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType scrollDirection /* UnityEngine.UI.Extensions.ScrollType */;
    [SerializeField] public float scrollSpeed /* System.Single */;
    [SerializeField] public bool cancelScrollOnInput /* System.Boolean */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.KeyCode> cancelScrollKeycodes /* System.Collections.Generic.List<UnityEngine.KeyCode> */;

    public enum ScrollType {
        VERTICAL = 0,
        HORIZONTAL = 1,
        BOTH = 2,
    }

}

}

