using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Ping {

public class PingHighlighter : MonoBehaviour {
    public bool IsActive /* System.Boolean */;
    public PingHighlighter.TypeLit Lit /* Kingmaker.UI.Ping.TypeLit */;
    public AnimationCurve CurveBlink /* UnityEngine.AnimationCurve */;
    public Graphic TargetGraphic /* UnityEngine.UI.Graphic */;

    public enum TypeLit {
        Lit = 0,
        Blink = 1,
    }

}

}

