using System;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapPawn : global::UnityEngine.MonoBehaviour {
    public bool DissolveOnLocationEnter /* System.Boolean */;
    public bool DissolveNearPlayer /* System.Boolean */;
    public global::UnityEngine.Renderer PawnRenderer /* UnityEngine.Renderer */;
    public float MaxDissolveDistance /* System.Single */;
    public global::UnityEngine.GameObject SelectedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.Color m_HighlightColor /* UnityEngine.Color */;
}

}

