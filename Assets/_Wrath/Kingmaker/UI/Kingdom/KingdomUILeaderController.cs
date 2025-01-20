using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUILeaderController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NavigationTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RoleDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CompanionDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUILeaderCharacterController m_PortraitController /* Kingmaker.UI.Kingdom.KingdomUILeaderCharacterController */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIChooseCompanionController m_ChooseCompanion /* Kingmaker.UI.Kingdom.KingdomUIChooseCompanionController */;
    [SerializeField] public object m_NoCompanionsLabel /* TMPro.TextMeshProUGUI */;
}

}

