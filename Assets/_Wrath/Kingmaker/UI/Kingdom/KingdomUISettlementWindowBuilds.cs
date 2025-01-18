using Kingmaker.UI.Settlement;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUISettlementWindowBuilds : MonoBehaviour {
    [SerializeField] public SettlementBuildingItem m_BuildingItem /* Kingmaker.UI.Settlement.SettlementBuildingItem */;
    [SerializeField] public RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public object m_BuildFreeLabel /* TMPro.TextMeshProUGUI */;
}

}

