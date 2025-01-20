using System;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapPointView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Globalmap.Blueprints.Reference */;
    public global::UnityEngine.GameObject LocationVisual /* UnityEngine.GameObject */;
    public global::UnityEngine.Transform LocationVisualPostion /* UnityEngine.Transform */;
    public global::UnityEngine.Transform LocationTooltipPoint /* UnityEngine.Transform */;
    public bool DissolvePlayer /* System.Boolean */;
    public bool OverrideHCol /* System.Boolean */;
    public global::UnityEngine.Color HoverColor /* UnityEngine.Color */;
    public global::UnityEngine.Color SelectColor /* UnityEngine.Color */;
    public global::UnityEngine.Color CurrentColor /* UnityEngine.Color */;
}

}

