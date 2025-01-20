using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityEngine.UI {

public class KingmakerGraphicRaycaster {
    [SerializeField] public bool m_IgnoreReversedGraphics /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.KingmakerGraphicRaycaster.BlockingObjects m_BlockingObjects /* UnityEngine.UI.BlockingObjects */;
    [SerializeField] public global::UnityEngine.LayerMask m_BlockingMask /* UnityEngine.LayerMask */;

    public enum BlockingObjects {
        None = 0,
        TwoD = 1,
        ThreeD = 2,
        All = 3,
    }

}

}

