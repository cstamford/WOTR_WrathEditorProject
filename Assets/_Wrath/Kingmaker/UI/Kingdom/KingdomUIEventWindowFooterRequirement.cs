using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindowFooterRequirement : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_RequiredLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_StatImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIResources m_Resources /* Kingmaker.UI.Kingdom.KingdomUIResources */;
    [SerializeField] public global::UnityEngine.GameObject m_NotEnoughObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_NotEnoughResourcesLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NoLeaderAvailableLabel /* TMPro.TextMeshProUGUI */;
}

}

