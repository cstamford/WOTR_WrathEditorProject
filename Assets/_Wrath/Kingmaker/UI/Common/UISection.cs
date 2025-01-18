using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.Common {

public class UISection : MonoBehaviour {
    public List<int> SectionGroupIndex /* System.Collections.Generic.List<System.Int32> */;
    public List<Vector2> Positions /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    public List<Vector2> Sizes /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    public float Duration /* System.Single */;
    public bool AlwaysHidden /* System.Boolean */;
    public bool Move /* System.Boolean */;
    public UISection.AppearDirection Direction /* Kingmaker.UI.Common.AppearDirection */;
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

