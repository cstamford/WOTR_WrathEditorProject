using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.Encyclopedia {

public class HierarchyElement : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelHighlight /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_SelectGraphic /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Encyclopedia.HierarchyElement m_ChildSource /* Kingmaker.UI.ServiceWindow.Encyclopedia.HierarchyElement */;
    [SerializeField] public global::UnityEngine.Transform m_Content /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_ExpandArrow /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject m_Arrow /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_Dot /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject[] m_HighlightObjects /* UnityEngine.GameObject[] */;
}

}

