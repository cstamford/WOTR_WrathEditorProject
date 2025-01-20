using System;
using UnityEngine;

namespace Kingmaker.UI.Common {

public class ResizePanel : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.Vector2 MaxSize /* UnityEngine.Vector2 */;
    public global::UnityEngine.Vector2 MinSize /* UnityEngine.Vector2 */;
    public global::Kingmaker.UI.Common.ResizePanel.ResizePivot Pivot /* Kingmaker.UI.Common.ResizePivot */;
    public global::UnityEngine.GameObject TargetGameObject /* UnityEngine.GameObject */;

    public enum ResizePivot {
        TopLeft = 0,
        Top = 1,
        TopRight = 2,
        Left = 3,
        Right = 4,
        BottomLeft = 5,
        Bottom = 6,
        BottomRight = 7,
    }

}

}

