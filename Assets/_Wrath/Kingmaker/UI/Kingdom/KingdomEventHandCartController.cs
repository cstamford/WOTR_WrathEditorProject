using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomEventHandCartController : MonoBehaviour {
    [SerializeField] public object m_EventName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_TypeImage /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_Fx /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_CantStartObject /* UnityEngine.GameObject */;
}

}

