using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ActionBar {

public class BaseSwitchButton : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Image m_Image /* UnityEngine.UI.Image */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger EnableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger DisableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public global::UnityEngine.Sprite IconOff /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite IconOn /* UnityEngine.Sprite */;
}

}

