using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Kingmaker.UI.Common {

public class ContentSizeFitterExtended {
    [SerializeField] public global::Kingmaker.UI.Common.ContentSizeFitterExtended.FitMode m_HorizontalFit /* Kingmaker.UI.Common.FitMode */;
    [SerializeField] public global::Kingmaker.UI.Common.ContentSizeFitterExtended.FitMode m_VerticalFit /* Kingmaker.UI.Common.FitMode */;

    public enum FitMode {
        Unconstrained = 0,
        MinSize = 1,
        PreferredSize = 2,
        Clamp = 3,
    }

}

}

