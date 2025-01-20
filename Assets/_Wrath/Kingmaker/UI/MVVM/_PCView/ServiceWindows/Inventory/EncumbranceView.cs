using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory {

public class EncumbranceView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_CurrentLoadSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Slider m_LightLoadSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Slider m_MediumLoadSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_LightLoadLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MediumLoadLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HeavyLoadLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentLoadStatus /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentLoadWeight /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_LightColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_MiddleColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_HeavyColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_OverloadColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.UI.Graphic m_FillGraphic /* UnityEngine.UI.Graphic */;
    [SerializeField] public global::UnityEngine.RectTransform m_LabelsContainer /* UnityEngine.RectTransform */;
}

}

