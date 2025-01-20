using System;
using UnityEngine;

namespace Kingmaker.UI.Tooltip {

public class DescriptionController : global::Kingmaker.UI.Tooltip.TooltipsController {
    public global::Kingmaker.UI.Tooltip.DescriptionWindow DescWindow /* Kingmaker.UI.Tooltip.DescriptionWindow */;
    public global::Kingmaker.UI.Tooltip.DescriptionWindowSmallBook SmallBook /* Kingmaker.UI.Tooltip.DescriptionWindowSmallBook */;

    public enum DescWindowType {
        Default = 0,
        SmallBook = 1,
        FullScreenBook = 2,
    }

}

}

