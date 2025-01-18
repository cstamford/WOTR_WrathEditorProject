using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapLocationInfoResourceStats : MonoBehaviour {
    [SerializeField] public GameObject m_BpContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_RegionName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BpPerOnce /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BpPerTurn /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Owned /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Stat /* Kingmaker.UI.Kingdom.KingdomEventResultStat */;
    [SerializeField] public RectTransform m_StatContainer /* UnityEngine.RectTransform */;
}

}

