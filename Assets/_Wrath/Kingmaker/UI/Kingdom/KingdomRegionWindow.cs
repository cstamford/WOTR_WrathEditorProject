using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomRegionWindow : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TitleNavigation /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomUIResourcesChanges m_RegionResourcesChanges /* Kingmaker.UI.Kingdom.KingdomUIResourcesChanges */;
    [SerializeField] public GameObject m_UpgradeContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_UpgradeDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomUIResourcesChanges m_UpgradeResourcesChanges /* Kingmaker.UI.Kingdom.KingdomUIResourcesChanges */;
}

}

