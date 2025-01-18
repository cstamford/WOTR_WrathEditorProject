using UnityEngine;

namespace Kingmaker.UI.Common {

public class ResizePanel : MonoBehaviour {
    public Vector2 MaxSize /* UnityEngine.Vector2 */;
    public Vector2 MinSize /* UnityEngine.Vector2 */;
    public ResizePanel.ResizePivot Pivot /* Kingmaker.UI.Common.ResizePivot */;
    public GameObject TargetGameObject /* UnityEngine.GameObject */;

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

