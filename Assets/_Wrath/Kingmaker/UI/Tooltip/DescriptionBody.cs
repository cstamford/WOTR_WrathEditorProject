using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Tooltip {

public class DescriptionBody : MonoBehaviour {
    public GameObject TooltipBody /* UnityEngine.GameObject */;
    public DescriptionBricksBox ContentBox /* Kingmaker.UI.Tooltip.DescriptionBricksBox */;
    public DescriptionBricksBox HeaderBox /* Kingmaker.UI.Tooltip.DescriptionBricksBox */;
    public DescriptionBricksBox FooterBox /* Kingmaker.UI.Tooltip.DescriptionBricksBox */;
    public GameObject BottomShadow /* UnityEngine.GameObject */;
    public GameObject RightClickBlock /* UnityEngine.GameObject */;
    public List<Image> Backgrounds /* System.Collections.Generic.List<UnityEngine.UI.Image> */;
}

}

