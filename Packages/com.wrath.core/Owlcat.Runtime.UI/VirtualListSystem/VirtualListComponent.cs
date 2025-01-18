using System;
using UnityEngine;
using UnityEngine.UI;

namespace Owlcat.Runtime.UI.VirtualListSystem {

public class VirtualListComponent : MonoBehaviour {
    [SerializeField] public RectTransform m_Viewport /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public Scrollbar m_Scrollbar /* UnityEngine.UI.Scrollbar */;
    [SerializeField] public Button m_BeginButton /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_EndButton /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ScrollSettings /* Owlcat.Runtime.UI.VirtualListSystem.VirtualListScrollSettings */;
    [SerializeField] public bool m_ClearItemsAnyway /* System.Boolean */;
}

}

