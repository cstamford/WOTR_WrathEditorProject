using Kingmaker.UI.Settlement;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIResourcesChanges : MonoBehaviour {
    [SerializeField] public BuildingItemStatListItem m_StatItem /* Kingmaker.UI.Settlement.BuildingItemStatListItem */;
    [SerializeField] public RectTransform m_StatsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public KingdomUIResource m_ResourcePrefab /* Kingmaker.UI.Kingdom.KingdomUIResource */;
    [SerializeField] public RectTransform m_PerTurnContainer /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_OneTimeContainer /* UnityEngine.RectTransform */;
}

}

