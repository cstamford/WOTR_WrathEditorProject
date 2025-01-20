using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal {

public class JournalQuestPCView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalQuestObjectivePCView QuestObjectiveViewPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalQuestObjectivePCView */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CompletionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_FailedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CompletedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_AttentionMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_LastChapterMark /* UnityEngine.GameObject */;
    [SerializeField] public object m_LastChapterText /* TMPro.TextMeshProUGUI */;
    public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::UnityEngine.GameObject m_QuestMarkerGroup /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_QuestMarkerImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_QuestMarkerText /* TMPro.TextMeshProUGUI */;
}

}

