using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.Common {

public class UISection : global::UnityEngine.MonoBehaviour {
    public global::System.Collections.Generic.List<int> SectionGroupIndex /* System.Collections.Generic.List<System.Int32> */;
    public global::System.Collections.Generic.List<global::UnityEngine.Vector2> Positions /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    public global::System.Collections.Generic.List<global::UnityEngine.Vector2> Sizes /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    public float Duration /* System.Single */;
    public bool AlwaysHidden /* System.Boolean */;
    public bool Move /* System.Boolean */;
    public global::Kingmaker.UI.Common.UISection.AppearDirection Direction /* Kingmaker.UI.Common.AppearDirection */;
    public float Range /* System.Single */;
    public bool Fade /* System.Boolean */;
    public bool GameObjectAlwaysActive /* System.Boolean */;

    public enum AppearDirection {
        North = 0,
        NordEast = 1,
        NordWest = 2,
        South = 3,
        SouthEast = 4,
        SouthWest = 5,
        West = 6,
        East = 7,
    }

}

}

