using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindowFooterCharacter : MonoBehaviour {
    [SerializeField] public object m_NoCompanioinBlock /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_CharacterBlock /* UnityEngine.GameObject */;
    [SerializeField] public KingdomUIChooseCompanionController m_ChooseController /* Kingmaker.UI.Kingdom.KingdomUIChooseCompanionController */;
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_Cross /* UnityEngine.GameObject */;
    [SerializeField] public Image m_StatIcon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StatName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public TooltipTrigger m_StatTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

