using UnityEngine;

namespace Kingmaker.Assets.UI.Common {

public class DraggbleWindow : MonoBehaviour {
    [SerializeField] public Vector2 m_TakeDrag /* UnityEngine.Vector2 */;
    [SerializeField] public RectTransform m_OwnRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_ParentRectTransform /* UnityEngine.RectTransform */;
}

}

