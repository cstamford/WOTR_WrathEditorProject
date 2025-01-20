using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Stories {

public class CharInfoStoriesConsoleView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryFullConsoleView m_CurrentSelectedStory /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryFullConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryConsoleView m_WidgetEntityView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

