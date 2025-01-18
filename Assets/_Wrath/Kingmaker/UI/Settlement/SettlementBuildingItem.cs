using Kingmaker.UI.Kingdom;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Settlement {

public class SettlementBuildingItem : MonoBehaviour {
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescriptionLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public Image m_SlotsImage /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_UpdateImage /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_Timer /* UnityEngine.GameObject */;
    [SerializeField] public object m_TimerLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomUIResources m_Resources /* Kingmaker.UI.Kingdom.KingdomUIResources */;
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

