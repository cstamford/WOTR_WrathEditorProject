using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ActionBar {

public class BaseSwitchButton : MonoBehaviour {
    [SerializeField] public Image m_Image /* UnityEngine.UI.Image */;
    public TooltipTrigger EnableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public TooltipTrigger DisableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public Sprite IconOff /* UnityEngine.Sprite */;
    public Sprite IconOn /* UnityEngine.Sprite */;
}

}

