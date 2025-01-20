using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapLocationInfo : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ResourceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LastVisited /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.GlobalMapLocationInfoRequireCompanions m_Companions /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoRequireCompanions */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.GlobalMapLocationInfoResourceStats m_ResouceStats /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoResourceStats */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.GlobalMapLocationInfoNewEventsView m_NewEvents /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoNewEventsView */;
}

}

