using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions {

public class UISelectableExtension : MonoBehaviour {
    public UISelectableExtension.UIButtonEvent OnButtonPress /* UnityEngine.UI.Extensions.UIButtonEvent */;
    public UISelectableExtension.UIButtonEvent OnButtonRelease /* UnityEngine.UI.Extensions.UIButtonEvent */;
    public UISelectableExtension.UIButtonEvent OnButtonHeld /* UnityEngine.UI.Extensions.UIButtonEvent */;

    public class UIButtonEvent : UnityEvent {
    }

}

}

