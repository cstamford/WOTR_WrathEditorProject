using System;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapPointView : MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Globalmap.Blueprints.Reference */;
    public GameObject LocationVisual /* UnityEngine.GameObject */;
    public Transform LocationVisualPostion /* UnityEngine.Transform */;
    public Transform LocationTooltipPoint /* UnityEngine.Transform */;
    public bool DissolvePlayer /* System.Boolean */;
    public bool OverrideHCol /* System.Boolean */;
    public Color HoverColor /* UnityEngine.Color */;
    public Color SelectColor /* UnityEngine.Color */;
    public Color CurrentColor /* UnityEngine.Color */;
}

}

