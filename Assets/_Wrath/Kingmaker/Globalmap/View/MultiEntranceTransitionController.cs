using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.Globalmap.View {

public class MultiEntranceTransitionController : MonoBehaviour {
    [SerializeField] public Selectable m_Button /* UnityEngine.UI.Selectable */;
    [SerializeField] public Image m_Image /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public object m_NameText /* TMPro.TextMeshProUGUI */;
}

}

