using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class PageNavigation : MonoBehaviour {
    [SerializeField] public object m_PreviousButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public Image m_PointPrefab /* UnityEngine.UI.Image */;
    [SerializeField] public Transform m_PointsContainer /* UnityEngine.Transform */;
    [SerializeField] public Sprite m_SelectedSprite /* UnityEngine.Sprite */;
    [SerializeField] public Sprite m_UnselectedSprite /* UnityEngine.Sprite */;
}

}

