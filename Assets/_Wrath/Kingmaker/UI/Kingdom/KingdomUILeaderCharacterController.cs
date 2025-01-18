using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUILeaderCharacterController : MonoBehaviour {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_Cross /* UnityEngine.GameObject */;
    [SerializeField] public Button m_PortraitButton /* UnityEngine.UI.Button */;
    [SerializeField] public Image m_StatIcon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StatName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public TooltipTrigger m_TooltipStat /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public GameObject m_Event /* UnityEngine.GameObject */;
    [SerializeField] public object m_EventName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_EventDescription /* TMPro.TextMeshProUGUI */;
}

}

