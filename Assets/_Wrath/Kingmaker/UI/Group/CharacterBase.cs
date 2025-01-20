using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class CharacterBase : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.Slider Health /* UnityEngine.UI.Slider */;
    public global::Kingmaker.UI.Group.GroupCharacterBuffs Buffs /* Kingmaker.UI.Group.GroupCharacterBuffs */;
    public global::Kingmaker.UI.Group.GroupCharacterPortraitController Portrait /* Kingmaker.UI.Group.GroupCharacterPortraitController */;
    [SerializeField] public global::UnityEngine.Transform LevelUpButton /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject EncumbranceIndiacator /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.Color EncumbranceHeavyLoad /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color EncumbranceOwerload /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.UI.Image PesonalEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image PartyEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject PesonalEncumbranceObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject PartyEncumbranceObject /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger EncumbranceTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

