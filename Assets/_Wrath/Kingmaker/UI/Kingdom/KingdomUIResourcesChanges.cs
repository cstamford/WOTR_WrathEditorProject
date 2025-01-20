using Kingmaker.UI.Settlement;
using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIResourcesChanges : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Settlement.BuildingItemStatListItem m_StatItem /* Kingmaker.UI.Settlement.BuildingItemStatListItem */;
    [SerializeField] public global::UnityEngine.RectTransform m_StatsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIResource m_ResourcePrefab /* Kingmaker.UI.Kingdom.KingdomUIResource */;
    [SerializeField] public global::UnityEngine.RectTransform m_PerTurnContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_OneTimeContainer /* UnityEngine.RectTransform */;
}

}

