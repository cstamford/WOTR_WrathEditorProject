using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Level;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo {

public class MythicInfoProgressionView {
    [SerializeField] public object m_MythicName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Level.LevelProgressionView m_LevelProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Level.LevelProgressionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_ProgressionColumnsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_ProgressionColumnPrefab /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionChupaChupsView m_ChupaChupsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionChupaChupsView */;
    [SerializeField] public global::UnityEngine.UI.Image m_Frame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_DefaultFrame /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.UI.Image m_FrameDecor /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_DefaultFrameDecor /* UnityEngine.Sprite */;
}

}

