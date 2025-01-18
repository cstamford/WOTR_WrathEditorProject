using UnityEngine;

namespace Kingmaker.UI.Common {

public class Paginator : MonoBehaviour {
    [SerializeField] public RectTransform m_ViewPort /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public PageNavigation m_PageNavigation /* Kingmaker.UI.Common.PageNavigation */;
    [SerializeField] public RectTransform m_ViewPortContainer /* UnityEngine.RectTransform */;
}

}

