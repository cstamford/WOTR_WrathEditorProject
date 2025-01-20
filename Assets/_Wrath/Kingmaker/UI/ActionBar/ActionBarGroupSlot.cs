using Kingmaker.UI.Constructor;
using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarGroupSlot : global::Kingmaker.UI.ActionBar.ActionBarSlot {
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF ToggleAdditionalSpells /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::UnityEngine.RectTransform ToggleAdditionalSpellsArrow /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject ToggleAdditionalSpellsFrame /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.ActionBar.ActionBarSpellsGroup SubGroup /* Kingmaker.UI.ActionBar.ActionBarSpellsGroup */;
    [SerializeField] public global::UnityEngine.GameObject NonEmptySlotFrame /* UnityEngine.GameObject */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public float ArrowAngleHide /* System.Single */;
    public float ArrowAngleShow /* System.Single */;
    public string DragPingKey /* System.String */;
}

}

