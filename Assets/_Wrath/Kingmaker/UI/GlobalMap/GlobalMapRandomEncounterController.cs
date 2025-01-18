using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapRandomEncounterController : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_PointsBlock /* UnityEngine.GameObject */;
    [SerializeField] public object m_Points /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_ContinueButton /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_AvoidBlock /* UnityEngine.GameObject */;
    [SerializeField] public object m_EnterLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AvoidLabel /* TMPro.TextMeshProUGUI */;
}

}

