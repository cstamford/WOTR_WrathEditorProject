using System;
using UnityEngine;
using UnityEngine.UI;

public class EncumbranceBar : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Slider m_CurrentLoadSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Slider m_LightLoadSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Slider m_MediumLoadSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_LightLoadLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MediumLoadLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HeavyLoadLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentLoadStatus /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentLoadValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_LightColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_MiddleColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_HeavyColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_OwerloadColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.UI.Graphic m_FillGraphic /* UnityEngine.UI.Graphic */;
    public global::UnityEngine.Gradient g /* UnityEngine.Gradient */;
}

