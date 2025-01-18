using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUILeaderController : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NavigationTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RoleDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CompanionDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomUILeaderCharacterController m_PortraitController /* Kingmaker.UI.Kingdom.KingdomUILeaderCharacterController */;
    [SerializeField] public KingdomUIChooseCompanionController m_ChooseCompanion /* Kingmaker.UI.Kingdom.KingdomUIChooseCompanionController */;
    [SerializeField] public object m_NoCompanionsLabel /* TMPro.TextMeshProUGUI */;
}

}

