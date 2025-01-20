using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class UICounter : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.Button LeftArrow /* UnityEngine.UI.Button */;
    public global::UnityEngine.UI.Button RightArrow /* UnityEngine.UI.Button */;
    public object Counter /* TMPro.TextMeshProUGUI */;
    public global::Kingmaker.UI.Common.UICounter.UICounterEvent OnChanged /* Kingmaker.UI.Common.UICounterEvent */;

    public class UICounterEvent : global::UnityEngine.Events.UnityEvent {
    }

}

}

