using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftProgressBar : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Slider m_ProgressBar /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Image m_SelectIconImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ItemIconImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.HorizontalLayoutGroup m_LayoutGroup /* UnityEngine.UI.HorizontalLayoutGroup */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Rest.RestCraftProgressBarPoint> m_Points /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Rest.RestCraftProgressBarPoint> */;
    [SerializeField] public global::UnityEngine.RectTransform m_ContainerRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_PointRect /* UnityEngine.RectTransform */;
    [SerializeField] public object m_DescText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ItemNameText /* TMPro.TextMeshProUGUI */;
}

}

