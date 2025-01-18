using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ActionBar {

public class ActionBarWeaponSetToggle : MonoBehaviour {
    [SerializeField] public object m_WeaponSets /* Kingmaker.UI.ActionBar.ActionBarWeaponSets */;
    public TooltipTrigger EnableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public TooltipTrigger DisableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public Image BackIcon /* UnityEngine.UI.Image */;
    public Sprite HandIcon /* UnityEngine.Sprite */;
    public RectTransform Arrow /* UnityEngine.RectTransform */;
    [SerializeField] public Image m_DisableLayer /* UnityEngine.UI.Image */;
}

}

