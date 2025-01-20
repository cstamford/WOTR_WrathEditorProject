using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions {

public class ImageExtended {
    [SerializeField] public global::UnityEngine.Sprite m_Sprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.UI.Extensions.ImageExtended.Type m_Type /* UnityEngine.UI.Extensions.Type */;
    [SerializeField] public bool m_PreserveAspect /* System.Boolean */;
    [SerializeField] public bool m_FillCenter /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.Extensions.ImageExtended.FillMethod m_FillMethod /* UnityEngine.UI.Extensions.FillMethod */;
    [SerializeField] public float m_FillAmount /* System.Single */;
    [SerializeField] public bool m_FillClockwise /* System.Boolean */;
    [SerializeField] public int m_FillOrigin /* System.Int32 */;
    [SerializeField] public global::UnityEngine.UI.Extensions.ImageExtended.Rotate m_Rotate /* UnityEngine.UI.Extensions.Rotate */;

    public enum Type {
        Simple = 0,
        Sliced = 1,
        Tiled = 2,
        Filled = 3,
    }

    public enum FillMethod {
        Horizontal = 0,
        Vertical = 1,
        Radial90 = 2,
        Radial180 = 3,
        Radial360 = 4,
    }

    public enum Rotate {
        Rotate0 = 0,
        Rotate90 = 1,
        Rotate180 = 2,
        Rotate270 = 3,
    }

}

}

