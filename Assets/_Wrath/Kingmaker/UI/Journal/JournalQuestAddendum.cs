using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestAddendum : MonoBehaviour {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_Complited /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Fail /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_NeedToAttention /* UnityEngine.UI.Image */;
}

}

