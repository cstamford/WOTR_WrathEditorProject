using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestObjective : MonoBehaviour {
    public JournalQuestAddendum Addendum /* Kingmaker.UI.Journal.JournalQuestAddendum */;
    public RectTransform AddendumContent /* UnityEngine.RectTransform */;
    public GameObject CollapseObject /* UnityEngine.GameObject */;
    public object Description /* TMPro.TextMeshProUGUI */;
    public object Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RectTransform m_CollapseButton /* UnityEngine.RectTransform */;
    [SerializeField] public Image m_Complite /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Fail /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ActiveLayer /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_NeedToAttention /* UnityEngine.UI.Image */;
    [SerializeField] public object m_TimeToFail /* TMPro.TextMeshProUGUI */;
}

}

