using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Settlement {

public class BuildingItem : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public Image m_ActiveLayer /* UnityEngine.UI.Image */;
    [SerializeField] public BuildingItem.RequiredStaff m_RequiredStaff /* Kingmaker.UI.Settlement.RequiredStaff */;
    [SerializeField] public BuildingItem.BenefitStuff m_Benefit /* Kingmaker.UI.Settlement.BenefitStuff */;
    [SerializeField] public BuildingItem.Visualize m_Visualize /* Kingmaker.UI.Settlement.Visualize */;

    public class RequiredStaff {
        public Image Slots /* UnityEngine.UI.Image */;
        public object Cost /* TMPro.TextMeshProUGUI */;
        public Image DiscountLayer /* UnityEngine.UI.Image */;
        public Color AllowColor /* UnityEngine.Color */;
        public Color DenyColor /* UnityEngine.Color */;
        public Color DiscountColor /* UnityEngine.Color */;
    }

    public class BenefitStuff {
        public BuildingItemStatList StatList /* Kingmaker.UI.Settlement.BuildingItemStatList */;
        public GameObject UpdateLabel /* UnityEngine.GameObject */;
        public GameObject Timer /* UnityEngine.GameObject */;
        public object TimerLabel /* TMPro.TextMeshProUGUI */;
    }

    public class Visualize {
        public CanvasGroup CanvasGroup /* UnityEngine.CanvasGroup */;
        public Image Background /* UnityEngine.UI.Image */;
    }

}

}

