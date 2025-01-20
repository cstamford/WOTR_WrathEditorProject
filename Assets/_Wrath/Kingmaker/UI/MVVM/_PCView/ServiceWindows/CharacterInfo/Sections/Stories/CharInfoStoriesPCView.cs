using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories {

public class CharInfoStoriesPCView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryFullPCView m_CurrentSelectedStory /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryFullPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryPCView m_WidgetEntityView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Stories.CharInfoCompanionStoryPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_StoriesContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

