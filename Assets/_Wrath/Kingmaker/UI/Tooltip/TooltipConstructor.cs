using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Tooltip {

public class TooltipConstructor : global::Kingmaker.UI.Tooltip.TooltipBase {
    public global::System.Collections.Generic.List<global::Kingmaker.UI.Tooltip.DescriptionBody> Bodies /* System.Collections.Generic.List<Kingmaker.UI.Tooltip.DescriptionBody> */;
    public global::Kingmaker.UI.Tooltip.DescriptionBody Body /* Kingmaker.UI.Tooltip.DescriptionBody */;
    public global::System.Collections.Generic.List<global::UnityEngine.UI.Image> ColorizeComponents /* System.Collections.Generic.List<UnityEngine.UI.Image> */;
    public global::Kingmaker.UI.Tooltip.TooltipConstructor.GradientColorGroup Normal /* Kingmaker.UI.Tooltip.GradientColorGroup */;
    public global::Kingmaker.UI.Tooltip.TooltipConstructor.GradientColorGroup Red /* Kingmaker.UI.Tooltip.GradientColorGroup */;
    public global::Kingmaker.UI.Tooltip.TooltipConstructor.GradientColorGroup Blue /* Kingmaker.UI.Tooltip.GradientColorGroup */;
    public global::Kingmaker.UI.Tooltip.TooltipConstructor.GradientColorGroup Yellow /* Kingmaker.UI.Tooltip.GradientColorGroup */;

    public class GradientColorGroup {
        public global::UnityEngine.Color Color1 /* UnityEngine.Color */;
        public global::UnityEngine.Color Color2 /* UnityEngine.Color */;
        public global::UnityEngine.Color ImageColor /* UnityEngine.Color */;
    }

}

}

