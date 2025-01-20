using System;
using UnityEngine;

namespace Kingmaker.UI.MainMenuUI {

public class MainMenuCameraAnchors : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.Transform StartPosition /* UnityEngine.Transform */;
    public global::UnityEngine.Transform MainPosition /* UnityEngine.Transform */;
    public object AspectRatioPresets /* Kingmaker.UI.MainMenuUI.AspectRatioPreset[] */;

    public class AspectRatioPreset {
        public int WidthProportion /* System.Int32 */;
        public int HeightProportion /* System.Int32 */;
        public global::UnityEngine.Transform Anchor /* UnityEngine.Transform */;
    }

}

}

