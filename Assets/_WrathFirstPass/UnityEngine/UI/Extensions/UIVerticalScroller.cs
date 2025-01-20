using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions {

public class UIVerticalScroller : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.RectTransform _scrollingPanel /* UnityEngine.RectTransform */;
    public global::UnityEngine.GameObject[] _arrayOfElements /* UnityEngine.GameObject[] */;
    public global::UnityEngine.RectTransform _center /* UnityEngine.RectTransform */;
    public int StartingIndex /* System.Int32 */;
    public global::UnityEngine.GameObject ScrollUpButton /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ScrollDownButton /* UnityEngine.GameObject */;
    public global::UnityEngine.Events.UnityEvent<int> ButtonClicked /* UnityEngine.Events.UnityEvent<System.Int32> */;
}

}

