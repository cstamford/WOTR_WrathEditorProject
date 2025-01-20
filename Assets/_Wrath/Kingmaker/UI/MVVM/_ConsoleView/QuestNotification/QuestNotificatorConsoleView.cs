using Kingmaker.UI.MVVM._PCView.QuestNotification;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.QuestNotification {

public class QuestNotificatorConsoleView : global::Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificatorView {
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_JournalHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

