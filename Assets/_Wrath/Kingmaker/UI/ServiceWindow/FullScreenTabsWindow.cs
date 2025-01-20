using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class FullScreenTabsWindow {
    public object SubWindowsList /* Kingmaker.UI.ServiceWindow.SubPair[] */;

    public class SubPair {
        public global::Kingmaker.UI.ServiceWindow.UIWindow SubWindow /* Kingmaker.UI.ServiceWindow.UIWindow */;
        public global::UnityEngine.UI.Button SubButton /* UnityEngine.UI.Button */;
    }

}

}

