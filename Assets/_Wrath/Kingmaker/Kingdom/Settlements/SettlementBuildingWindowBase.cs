using Kingmaker.UI.Kingdom;
using Kingmaker.UI.Settlement;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.Kingdom.Settlements {

public class SettlementBuildingWindowBase : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object TimeToBuild /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_TimeToBuildContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Settlement.BuildingItemStatList Stats /* Kingmaker.UI.Settlement.BuildingItemStatList */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIResources m_ResourcesPerMonth /* Kingmaker.UI.Kingdom.KingdomUIResources */;
    [SerializeField] public object Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object UpgradeToHint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object UpgradeToLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_UpgradeToLabelContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Settlement.BuildingItemStatList UpgradesToStats /* Kingmaker.UI.Settlement.BuildingItemStatList */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIResources m_UpgradesResourcesPerMonth /* Kingmaker.UI.Kingdom.KingdomUIResources */;
    [SerializeField] public global::UnityEngine.UI.Image m_SlotsImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_SlotsCount /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PriceLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIResources m_PriceResources /* Kingmaker.UI.Kingdom.KingdomUIResources */;
}

}

