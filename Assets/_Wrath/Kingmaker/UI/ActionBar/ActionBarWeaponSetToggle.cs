using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ActionBar {

public class ActionBarWeaponSetToggle : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.ActionBar.ActionBarWeaponSets m_WeaponSets /* Kingmaker.UI.ActionBar.ActionBarWeaponSets */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger EnableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger DisableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public global::UnityEngine.UI.Image BackIcon /* UnityEngine.UI.Image */;
    public global::UnityEngine.Sprite HandIcon /* UnityEngine.Sprite */;
    public global::UnityEngine.RectTransform Arrow /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Image m_DisableLayer /* UnityEngine.UI.Image */;
}

}

