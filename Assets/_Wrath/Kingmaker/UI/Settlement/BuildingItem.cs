using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Settlement {

public class BuildingItem : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Image m_ActiveLayer /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Settlement.BuildingItem.RequiredStaff m_RequiredStaff /* Kingmaker.UI.Settlement.RequiredStaff */;
    [SerializeField] public global::Kingmaker.UI.Settlement.BuildingItem.BenefitStuff m_Benefit /* Kingmaker.UI.Settlement.BenefitStuff */;
    [SerializeField] public global::Kingmaker.UI.Settlement.BuildingItem.Visualize m_Visualize /* Kingmaker.UI.Settlement.Visualize */;

    public class RequiredStaff {
        public global::UnityEngine.UI.Image Slots /* UnityEngine.UI.Image */;
        public object Cost /* TMPro.TextMeshProUGUI */;
        public global::UnityEngine.UI.Image DiscountLayer /* UnityEngine.UI.Image */;
        public global::UnityEngine.Color AllowColor /* UnityEngine.Color */;
        public global::UnityEngine.Color DenyColor /* UnityEngine.Color */;
        public global::UnityEngine.Color DiscountColor /* UnityEngine.Color */;
    }

    public class BenefitStuff {
        public global::Kingmaker.UI.Settlement.BuildingItemStatList StatList /* Kingmaker.UI.Settlement.BuildingItemStatList */;
        public global::UnityEngine.GameObject UpdateLabel /* UnityEngine.GameObject */;
        public global::UnityEngine.GameObject Timer /* UnityEngine.GameObject */;
        public object TimerLabel /* TMPro.TextMeshProUGUI */;
    }

    public class Visualize {
        public global::UnityEngine.CanvasGroup CanvasGroup /* UnityEngine.CanvasGroup */;
        public global::UnityEngine.UI.Image Background /* UnityEngine.UI.Image */;
    }

}

}

