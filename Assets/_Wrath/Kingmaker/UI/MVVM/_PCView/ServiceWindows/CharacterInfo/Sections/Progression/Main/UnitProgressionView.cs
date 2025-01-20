using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Feats;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Level;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main {

public class UnitProgressionView {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Level.LevelProgressionView m_LevelProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Level.LevelProgressionView */;
    [SerializeField] public object m_FeatsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Feats.FeatProgressionView m_FeatProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Feats.FeatProgressionView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListClasses /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.ClassProgressionView m_ClassProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.ClassProgressionView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListSharedProgressions /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.ProgressionView m_SharedProgressionPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.ProgressionView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

