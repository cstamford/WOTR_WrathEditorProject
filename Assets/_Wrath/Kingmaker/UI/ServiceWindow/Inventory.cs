using DG.Tweening;
using Kingmaker.UI.ServiceWindow.CharacterScreen;
using Kingmaker.UI.Tooltip;
using Kingmaker.UI.Vendor;
using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class Inventory {
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharacterScreenController Sheet /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharacterScreenController */;
    public global::Kingmaker.UI.Vendor.FilterController Filter /* Kingmaker.UI.Vendor.FilterController */;
    public global::Kingmaker.UI.ServiceWindow.Stash Stash /* Kingmaker.UI.ServiceWindow.Stash */;
    public global::Kingmaker.UI.ServiceWindow.CharDoll Doll /* Kingmaker.UI.ServiceWindow.CharDoll */;
    public object PlayerMoneyNow /* TMPro.TextMeshProUGUI */;
    public global::Kingmaker.UI.ServiceWindow.Inventory.EncumbranceContainer StashEncumbrance /* Kingmaker.UI.ServiceWindow.EncumbranceContainer */;
    public global::Kingmaker.UI.ServiceWindow.Inventory.EncumbranceContainer CharacterEncumbrance /* Kingmaker.UI.ServiceWindow.EncumbranceContainer */;

    public class EncumbranceContainer {
        [SerializeField] public bool m_TextEncumbrance /* System.Boolean */;
        public EncumbranceBar m_EncumbranceBar /* .EncumbranceBar */;
        public string FormatString /* System.String */;
        public object m_EncumbranceLabel /* TMPro.TextMeshProUGUI */;
        public global::DG.Tweening.DOTweenAnimation m_LabelTween /* DG.Tweening.DOTweenAnimation */;
        public global::UnityEngine.Color m_LabelOwerloadColor /* UnityEngine.Color */;
        public global::Kingmaker.UI.Tooltip.TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    }

}

}

