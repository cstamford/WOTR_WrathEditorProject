using System;
using UnityEngine;

namespace Kingmaker.UI._ConsoleUI.TurnBasedMode {

public class TurnVirtualListController : MonoBehaviour {
    [SerializeField] public TurnVirtualListController.VirtualListDirection m_VirtualDirection /* Kingmaker.UI._ConsoleUI.TurnBasedMode.VirtualListDirection */;
    [SerializeField] public RectOffset Padding /* UnityEngine.RectOffset */;
    [SerializeField] public Vector2 Spacing /* UnityEngine.Vector2 */;
    [SerializeField] public object m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public float m_AutoScrollDelta /* System.Single */;
    public int ElementsInRow /* System.Int32 */;
    [SerializeField] public float m_AnimationTime /* System.Single */;

    public enum VirtualListDirection {
        None = 0,
        Vertical = 1,
        Horizontal = 2,
    }

}

}

