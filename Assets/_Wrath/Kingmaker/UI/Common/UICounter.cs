using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class UICounter : MonoBehaviour {
    public Button LeftArrow /* UnityEngine.UI.Button */;
    public Button RightArrow /* UnityEngine.UI.Button */;
    public object Counter /* TMPro.TextMeshProUGUI */;
    public UICounter.UICounterEvent OnChanged /* Kingmaker.UI.Common.UICounterEvent */;

    public class UICounterEvent : UnityEvent {
    }

}

}

