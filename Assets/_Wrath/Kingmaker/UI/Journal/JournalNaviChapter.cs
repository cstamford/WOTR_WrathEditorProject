using UnityEngine;

namespace Kingmaker.UI.Journal {

public class JournalNaviChapter : MonoBehaviour {
    public Transform Content /* UnityEngine.Transform */;
    public JournalQuestNaviElement QuestNaviElement /* Kingmaker.UI.Journal.JournalQuestNaviElement */;
    [SerializeField] public object m_NonActiveHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_NonActiveBackground /* UnityEngine.GameObject */;
    [SerializeField] public RectTransform m_NonActiveCollapseButton /* UnityEngine.RectTransform */;
    [SerializeField] public object m_ActiveHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_ActiveBackground /* UnityEngine.GameObject */;
    [SerializeField] public RectTransform m_ActiveCollapseButton /* UnityEngine.RectTransform */;
}

}

