using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestNaviElement : MonoBehaviour {
    [SerializeField] public object m_ActiveHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_ActiveBackground /* UnityEngine.GameObject */;
    [SerializeField] public object m_NonActiveHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_NonActiveBackground /* UnityEngine.GameObject */;
    [SerializeField] public Image m_Fail /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Complite /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_NeedToAttention /* UnityEngine.UI.Image */;
}

}

