using System;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapPawn : MonoBehaviour {
    public bool DissolveOnLocationEnter /* System.Boolean */;
    public bool DissolveNearPlayer /* System.Boolean */;
    public Renderer PawnRenderer /* UnityEngine.Renderer */;
    public float MaxDissolveDistance /* System.Single */;
    public GameObject SelectedMark /* UnityEngine.GameObject */;
    [SerializeField] public Color m_HighlightColor /* UnityEngine.Color */;
}

}

