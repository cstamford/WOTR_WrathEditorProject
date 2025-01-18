using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Tooltip {

public class DescriptionBrick : MonoBehaviour {
    public string BlockID /* System.String */;
    public object TextFields /* System.Collections.Generic.List */;
    public List<Image> Images /* System.Collections.Generic.List<UnityEngine.UI.Image> */;
    public List<DescriptionBricksBox> Boxes /* System.Collections.Generic.List<Kingmaker.UI.Tooltip.DescriptionBricksBox> */;
    public object Containers /* System.Collections.Generic.List */;
    public List<TooltipTrigger> Tooltips /* System.Collections.Generic.List<Kingmaker.UI.Tooltip.TooltipTrigger> */;
    public bool StaticElement /* System.Boolean */;
    public Button Button /* UnityEngine.UI.Button */;
}

}

