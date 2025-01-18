using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions {

public class ReorderableList : MonoBehaviour {
    public LayoutGroup ContentLayout /* UnityEngine.UI.LayoutGroup */;
    public RectTransform DraggableArea /* UnityEngine.RectTransform */;
    public bool IsDraggable /* System.Boolean */;
    public bool CloneDraggedObject /* System.Boolean */;
    public bool IsDropable /* System.Boolean */;
    public ReorderableList.ReorderableListHandler OnElementDropped /* UnityEngine.UI.Extensions.ReorderableListHandler */;
    public ReorderableList.ReorderableListHandler OnElementGrabbed /* UnityEngine.UI.Extensions.ReorderableListHandler */;
    public ReorderableList.ReorderableListHandler OnElementRemoved /* UnityEngine.UI.Extensions.ReorderableListHandler */;

    public class ReorderableListHandler : UnityEvent {
    }

}

}

