using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapMessageBox : MonoBehaviour {
    [SerializeField] public CanvasGroup m_Dialog /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_AcceptText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GlobalMapLocationInfoRequireCompanions m_Companions /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoRequireCompanions */;
    [SerializeField] public GlobalMapLocationInfoResourceStats m_ResouceStats /* Kingmaker.UI.GlobalMap.GlobalMapLocationInfoResourceStats */;
    [SerializeField] public GameObject m_StandartControllers /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_OkControllers /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_TeleportControllers /* UnityEngine.GameObject */;
}

}

