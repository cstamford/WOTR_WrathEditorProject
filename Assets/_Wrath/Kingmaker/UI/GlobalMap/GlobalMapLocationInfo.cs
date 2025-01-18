using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapLocationInfo : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ResourceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LastVisited /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GlobalMapLocationInfoRequireCompanions m_Companions /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoRequireCompanions */;
    [SerializeField] public GlobalMapLocationInfoResourceStats m_ResouceStats /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoResourceStats */;
    [SerializeField] public GlobalMapLocationInfoNewEventsView m_NewEvents /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoNewEventsView */;
}

}

