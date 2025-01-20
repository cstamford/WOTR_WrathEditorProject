using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindowFooterCharacter : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_NoCompanioinBlock /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_CharacterBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIChooseCompanionController m_ChooseController /* Kingmaker.UI.Kingdom.KingdomUIChooseCompanionController */;
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_Cross /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_StatIcon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StatName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_StatValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_StatTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

