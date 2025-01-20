using Kingmaker.UI.Constructor;
using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.IngameMenu {

public class IngameMenuController : global::Kingmaker.UI.IngameMenu.IngameMenuManager {
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.UI.Image m_InspectActive /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_TBMActive /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_SandClock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_EndTurnButton /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::Kingmaker.UI.IngameMenu.IngameMenuController.Clock m_Clock /* Kingmaker.UI.IngameMenu.Clock */;

    public class Clock {
        public global::UnityEngine.Transform Hourglass /* UnityEngine.Transform */;
        public global::UnityEngine.Transform Gear01 /* UnityEngine.Transform */;
        public global::UnityEngine.Transform Gear02 /* UnityEngine.Transform */;
    }

}

}

