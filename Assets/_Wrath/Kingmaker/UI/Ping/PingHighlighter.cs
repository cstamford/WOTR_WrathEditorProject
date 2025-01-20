using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Ping {

public class PingHighlighter : global::UnityEngine.MonoBehaviour {
    public bool IsActive /* System.Boolean */;
    public global::Kingmaker.UI.Ping.PingHighlighter.TypeLit Lit /* Kingmaker.UI.Ping.TypeLit */;
    public global::UnityEngine.AnimationCurve CurveBlink /* UnityEngine.AnimationCurve */;
    public global::UnityEngine.UI.Graphic TargetGraphic /* UnityEngine.UI.Graphic */;

    public enum TypeLit {
        Lit = 0,
        Blink = 1,
    }

}

}

