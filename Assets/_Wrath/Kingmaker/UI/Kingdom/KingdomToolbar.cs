using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomToolbar : MonoBehaviour {
    [SerializeField] public KingdomBuffsCollectionController m_BuffCollection /* Kingmaker.UI.Kingdom.KingdomBuffsCollectionController */;
    [SerializeField] public object m_State /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_StateUp /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_StateDown /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Motto /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Date /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Time /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_SkipTime /* UnityEngine.UI.Button */;
    [SerializeField] public TooltipTrigger m_SkipTimeTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public RectTransform m_Clock /* UnityEngine.RectTransform */;
}

}

