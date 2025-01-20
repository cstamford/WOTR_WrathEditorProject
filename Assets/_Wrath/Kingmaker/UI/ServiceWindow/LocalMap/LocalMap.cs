using Kingmaker.UI.ServiceWindow;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.LocalMap {

public class LocalMap {
    public global::UnityEngine.UI.RawImage Image /* UnityEngine.UI.RawImage */;
    public object Title /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.RectTransform Frame /* UnityEngine.RectTransform */;
    public global::UnityEngine.Vector2 MaxSize /* UnityEngine.Vector2 */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.LocalMap.LocalMap.MarkSet> Marks /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.LocalMap.MarkSet> */;

    public class MarkSet {
        public object Type /* Kingmaker.UI.MVVM._VM.ServiceWindows.LocalMap.Utils.LocalMapMarkType */;
        public global::UnityEngine.RectTransform Container /* UnityEngine.RectTransform */;
        public global::Kingmaker.UI.ServiceWindow.LocalMap.LocalMapMark Mark /* Kingmaker.UI.ServiceWindow.LocalMap.LocalMapMark */;
        public bool IsShow /* System.Boolean */;
        public global::UnityEngine.UI.Button Filter /* UnityEngine.UI.Button */;
        public global::UnityEngine.UI.Image Active /* UnityEngine.UI.Image */;
    }

}

}

