using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class GroupController : MonoBehaviour {
    public float HidePosY /* System.Single */;
    public float ShowPosY /* System.Single */;
    public float AnimTime /* System.Single */;
    [SerializeField] public Image m_Shadow /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_NaviBlock /* UnityEngine.GameObject */;
    [SerializeField] public object m_LeftArrow /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public object m_RightArrow /* Kingmaker.UI.Constructor.ButtonPF */;
}

}

