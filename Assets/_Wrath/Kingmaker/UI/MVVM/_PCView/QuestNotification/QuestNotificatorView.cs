using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.QuestNotification {

public class QuestNotificatorView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_Animator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationQuestPCView m_QuestView /* Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationQuestPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationObjectivesPCView m_QuestObjectiveView_1 /* Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationObjectivesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationObjectivesPCView m_QuestObjectiveView_2 /* Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationObjectivesPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationAddendumPCView m_QuestObjectiveView_Addendum /* Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificationAddendumPCView */;
}

}

