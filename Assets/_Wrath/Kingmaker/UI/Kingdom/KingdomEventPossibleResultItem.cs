using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomEventPossibleResultItem : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RectTransform m_TitleArrow /* UnityEngine.RectTransform */;
    [SerializeField] public Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_ExpandContent /* UnityEngine.GameObject */;
    [SerializeField] public object m_Solution /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPOneTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerTurn /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_BPContainer /* UnityEngine.GameObject */;
    [SerializeField] public RectTransform m_StatContainer /* UnityEngine.RectTransform */;
    [SerializeField] public KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
}

}

