using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIResource : MonoBehaviour {
    [SerializeField] public Image m_IconImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_CountLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Color m_NormalColor /* UnityEngine.Color */;
    [SerializeField] public Color m_NotEnoughColor /* UnityEngine.Color */;
}

}

