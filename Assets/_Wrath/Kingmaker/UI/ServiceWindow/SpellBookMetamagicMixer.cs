using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookMetamagicMixer : MonoBehaviour {
    [SerializeField] public object m_MetamagicLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_WriteButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Transform m_FeatsSelector /* UnityEngine.Transform */;
    [SerializeField] public Transform m_MixerContainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_SorceSpellLevel /* UnityEngine.Transform */;
    [SerializeField] public object m_SorceSpellLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_ResultSpellLevelBackGround /* UnityEngine.UI.Image */;
    [SerializeField] public Color m_ResultSpellLevelNormal /* UnityEngine.Color */;
    [SerializeField] public Color m_ResultSpellLevelCanNotWrite /* UnityEngine.Color */;
    [SerializeField] public TooltipTrigger m_ResultSpellLevelTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public Transform m_ResultSpellLevel /* UnityEngine.Transform */;
    [SerializeField] public object m_ResultSpellLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ResultSpellLevelLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_ResultSpellLevelDown /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_ResultSpellLevelUp /* UnityEngine.UI.Button */;
    [SerializeField] public object m_SpellName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_SpellClearButtonContainer /* UnityEngine.UI.Button */;
    [SerializeField] public Transform m_SpellClearButton /* UnityEngine.Transform */;
    [SerializeField] public object m_SpellSlot /* Kingmaker.UI.ServiceWindow.SpellItemMixer */;
    [SerializeField] public Image m_SpellIconHighlighter /* UnityEngine.UI.Image */;
    [SerializeField] public Transform m_MetamagicSlotsContainer /* UnityEngine.Transform */;
    [SerializeField] public Button m_WriteButton /* UnityEngine.UI.Button */;
    [SerializeField] public TooltipTrigger m_WriteButtonTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public Transform m_NoMetamagicTextContainer /* UnityEngine.Transform */;
    [SerializeField] public object m_NoMetamagicText /* TMPro.TextMeshProUGUI */;
    public bool HasMetamagic /* System.Boolean */;
}

}

