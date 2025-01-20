using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapMessageBox : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.CanvasGroup m_Dialog /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_AcceptText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.GlobalMapLocationInfoRequireCompanions m_Companions /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoRequireCompanions */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.GlobalMapLocationInfoResourceStats m_ResouceStats /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoResourceStats */;
    [SerializeField] public global::UnityEngine.GameObject m_StandartControllers /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_OkControllers /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_TeleportControllers /* UnityEngine.GameObject */;
}

}

