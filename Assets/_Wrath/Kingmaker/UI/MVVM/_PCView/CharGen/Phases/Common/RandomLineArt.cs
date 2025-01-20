using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common {

public class RandomLineArt : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.RandomLineArt.RandomLineArtDirection m_Direction /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.RandomLineArtDirection */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Sprite> m_VerticalSprites /* System.Collections.Generic.List<UnityEngine.Sprite> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Sprite> m_HorizontalSprites /* System.Collections.Generic.List<UnityEngine.Sprite> */;
    [SerializeField] public global::UnityEngine.UI.Image m_LineImage /* UnityEngine.UI.Image */;

    public enum RandomLineArtDirection {
        Horizontal = 0,
        Vertical = 1,
    }

}

}

