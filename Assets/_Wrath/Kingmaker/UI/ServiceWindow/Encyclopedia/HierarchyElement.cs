using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.Encyclopedia {

public class HierarchyElement : MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelHighlight /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_SelectGraphic /* UnityEngine.UI.Image */;
    [SerializeField] public HierarchyElement m_ChildSource /* Kingmaker.UI.ServiceWindow.Encyclopedia.HierarchyElement */;
    [SerializeField] public Transform m_Content /* UnityEngine.Transform */;
    [SerializeField] public Transform m_ExpandArrow /* UnityEngine.Transform */;
    [SerializeField] public GameObject m_Arrow /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_Dot /* UnityEngine.GameObject */;
    public GameObject[] m_HighlightObjects /* UnityEngine.GameObject[] */;
}

}

