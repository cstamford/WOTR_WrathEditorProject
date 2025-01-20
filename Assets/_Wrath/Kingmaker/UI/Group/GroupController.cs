using Kingmaker.UI.Constructor;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class GroupController : global::UnityEngine.MonoBehaviour {
    public float HidePosY /* System.Single */;
    public float ShowPosY /* System.Single */;
    public float AnimTime /* System.Single */;
    [SerializeField] public global::UnityEngine.UI.Image m_Shadow /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_NaviBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_LeftArrow /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_RightArrow /* Kingmaker.UI.Constructor.ButtonPF */;
}

}

