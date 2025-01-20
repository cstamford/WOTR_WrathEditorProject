using Kingmaker.UI.MVVM._PCView.Rest;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.LocalMap {

public class LocalMapBaseView {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LocationTypeText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_BPRImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_Image /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::UnityEngine.RectTransform m_FrameBlock /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_Frame /* UnityEngine.RectTransform */;
    [SerializeField] public object m_MarkerSets /* System.Collections.Generic.List */;
    [SerializeField] public global::UnityEngine.GameObject m_LegendGroup /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestCorruptionProgressBarPCView m_CorruptionProgressBar /* Kingmaker.UI.MVVM._PCView.Rest.RestCorruptionProgressBarPCView */;
    [SerializeField] public object FriendIconName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object EnemyIconName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object CameraIconName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object LootIconName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object ExitIconName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object PointOfInterestIconName /* TMPro.TextMeshProUGUI */;
    public bool m_IsLegendShow /* System.Boolean */;
}

}

