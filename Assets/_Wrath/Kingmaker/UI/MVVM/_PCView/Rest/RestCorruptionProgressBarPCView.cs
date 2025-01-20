using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCorruptionProgressBarPCView {
    [SerializeField] public global::UnityEngine.GameObject m_CorruptionGroup /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Slider m_MaxValueSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Slider m_CurrentValueSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_CurrentCorruptionLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestCorruptionProgressBarPoint m_CorruptionPointPrefab /* Kingmaker.UI.MVVM._PCView.Rest.RestCorruptionProgressBarPoint */;
    [SerializeField] public global::UnityEngine.RectTransform m_PointsContainer /* UnityEngine.RectTransform */;
}

}

