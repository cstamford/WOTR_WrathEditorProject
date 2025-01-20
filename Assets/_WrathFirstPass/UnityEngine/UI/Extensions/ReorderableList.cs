using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions {

public class ReorderableList : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.LayoutGroup ContentLayout /* UnityEngine.UI.LayoutGroup */;
    public global::UnityEngine.RectTransform DraggableArea /* UnityEngine.RectTransform */;
    public bool IsDraggable /* System.Boolean */;
    public bool CloneDraggedObject /* System.Boolean */;
    public bool IsDropable /* System.Boolean */;
    public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementDropped /* UnityEngine.UI.Extensions.ReorderableListHandler */;
    public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementGrabbed /* UnityEngine.UI.Extensions.ReorderableListHandler */;
    public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementRemoved /* UnityEngine.UI.Extensions.ReorderableListHandler */;

    public class ReorderableListHandler : global::UnityEngine.Events.UnityEvent {
    }

}

}

