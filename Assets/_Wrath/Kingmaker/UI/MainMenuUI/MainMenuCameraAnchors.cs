using System;
using UnityEngine;

namespace Kingmaker.UI.MainMenuUI {

public class MainMenuCameraAnchors : MonoBehaviour {
    public Transform StartPosition /* UnityEngine.Transform */;
    public Transform MainPosition /* UnityEngine.Transform */;
    public object AspectRatioPresets /* Kingmaker.UI.MainMenuUI.AspectRatioPreset[] */;

    public class AspectRatioPreset {
        public int WidthProportion /* System.Int32 */;
        public int HeightProportion /* System.Int32 */;
        public Transform Anchor /* UnityEngine.Transform */;
    }

}

}

