using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common {

public class RandomLineArt : MonoBehaviour {
    [SerializeField] public RandomLineArt.RandomLineArtDirection m_Direction /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.RandomLineArtDirection */;
    [SerializeField] public List<Sprite> m_VerticalSprites /* System.Collections.Generic.List<UnityEngine.Sprite> */;
    [SerializeField] public List<Sprite> m_HorizontalSprites /* System.Collections.Generic.List<UnityEngine.Sprite> */;
    [SerializeField] public Image m_LineImage /* UnityEngine.UI.Image */;

    public enum RandomLineArtDirection {
        Horizontal = 0,
        Vertical = 1,
    }

}

}

