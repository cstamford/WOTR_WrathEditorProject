using System;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class VerticalScrollSnap : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.GameObject Pagination /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject NextButton /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject PrevButton /* UnityEngine.GameObject */;
    public float transitionSpeed /* System.Single */;
    public bool UseFastSwipe /* System.Boolean */;
    public int FastSwipeThreshold /* System.Int32 */;
    [SerializeField] public int _currentScreen /* System.Int32 */;
    public int StartingScreen /* System.Int32 */;
    public int PageStep /* System.Int32 */;
}

}

