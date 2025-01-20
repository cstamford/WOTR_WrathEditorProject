using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal {

public class JournalQuestObjectivePCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.ExpandableCollapseMultiButtonPC m_ExpandableCollapseMultiButton /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.ExpandableCollapseMultiButtonPC */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalQuestObjectiveAddendumPCView m_AddendumViewPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalQuestObjectiveAddendumPCView */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_AttentionMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_FailedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CompletedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_HighlightImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color m_FailedColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_CompletedColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_AttentionColor /* UnityEngine.Color */;
}

}

