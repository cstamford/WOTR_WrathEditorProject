using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ActionBar {

public class QuickBarButton : MonoBehaviour {
    public Image ActiveMark /* UnityEngine.UI.Image */;
    public Button Button /* UnityEngine.UI.Button */;
    public Image Icon /* UnityEngine.UI.Image */;
    public object Count /* TMPro.TextMeshProUGUI */;
    public Color DefaultColor /* UnityEngine.Color */;
    public Color RunningColor /* UnityEngine.Color */;
    public TooltipTrigger EnableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public TooltipTrigger DisableTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

