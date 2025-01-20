using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions {

public class ScrollSnap : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.Extensions.ScrollSnap.ScrollDirection direction /* UnityEngine.UI.Extensions.ScrollDirection */;
    public global::UnityEngine.UI.Button nextButton /* UnityEngine.UI.Button */;
    public global::UnityEngine.UI.Button prevButton /* UnityEngine.UI.Button */;
    public int itemsVisibleAtOnce /* System.Int32 */;
    public bool autoLayoutItems /* System.Boolean */;
    public bool linkScrolbarSteps /* System.Boolean */;
    public bool linkScrolrectScrollSensitivity /* System.Boolean */;
    public bool useFastSwipe /* System.Boolean */;
    public int fastSwipeThreshold /* System.Int32 */;

    public enum ScrollDirection {
        Horizontal = 0,
        Vertical = 1,
    }

}

}

