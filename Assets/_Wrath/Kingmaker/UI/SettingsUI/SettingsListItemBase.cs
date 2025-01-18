using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SettingsUI {

public class SettingsListItemBase : MonoBehaviour {
    public Image ItemBackground /* UnityEngine.UI.Image */;
    public object DescriptionLabel /* TMPro.TextMeshProUGUI */;
    public TooltipTrigger Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public bool NeedResetSessionValue /* System.Boolean */;
}

}

