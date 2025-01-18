using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.Tooltip {

public class TooltipTrigger : MonoBehaviour {
    public bool Disable /* System.Boolean */;
    public object TooltipType /* Kingmaker.UI.Tooltip.TooltipType */;
    public bool TypeAutoDefine /* System.Boolean */;
    public bool DescriptionWindowActive /* System.Boolean */;
    public bool RefreshEachShow /* System.Boolean */;
    public string KeyWords /* System.String */;
    public List<Vector2> PriorityPositions /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    public Transform PositionTransform /* UnityEngine.Transform */;
    public bool NotStaticData /* System.Boolean */;
    public bool HideByClick /* System.Boolean */;
}

}

