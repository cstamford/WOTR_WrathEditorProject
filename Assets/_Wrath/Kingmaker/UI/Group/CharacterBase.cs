using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class CharacterBase : MonoBehaviour {
    public Slider Health /* UnityEngine.UI.Slider */;
    public GroupCharacterBuffs Buffs /* Kingmaker.UI.Group.GroupCharacterBuffs */;
    public GroupCharacterPortraitController Portrait /* Kingmaker.UI.Group.GroupCharacterPortraitController */;
    [SerializeField] public Transform LevelUpButton /* UnityEngine.Transform */;
    [SerializeField] public GameObject EncumbranceIndiacator /* UnityEngine.GameObject */;
    [SerializeField] public Color EncumbranceHeavyLoad /* UnityEngine.Color */;
    [SerializeField] public Color EncumbranceOwerload /* UnityEngine.Color */;
    [SerializeField] public Image PesonalEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public Image PartyEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject PesonalEncumbranceObject /* UnityEngine.GameObject */;
    [SerializeField] public GameObject PartyEncumbranceObject /* UnityEngine.GameObject */;
    [SerializeField] public TooltipTrigger EncumbranceTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

