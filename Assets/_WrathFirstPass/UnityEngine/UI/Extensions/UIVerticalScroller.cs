using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions {

public class UIVerticalScroller : MonoBehaviour {
    public RectTransform _scrollingPanel /* UnityEngine.RectTransform */;
    public GameObject[] _arrayOfElements /* UnityEngine.GameObject[] */;
    public RectTransform _center /* UnityEngine.RectTransform */;
    public int StartingIndex /* System.Int32 */;
    public GameObject ScrollUpButton /* UnityEngine.GameObject */;
    public GameObject ScrollDownButton /* UnityEngine.GameObject */;
    public UnityEvent<int> ButtonClicked /* UnityEngine.Events.UnityEvent<System.Int32> */;
}

}

