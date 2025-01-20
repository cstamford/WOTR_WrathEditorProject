using Kingmaker.UI.Common;
using Kingmaker.UI.LevelUp;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.NewGame.Story {

public class NewGamePhaseStoryConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.NewGame.Story.NewGamePhaseStoryScenarioSelectorConsoleView m_SelectorConsoleView /* Kingmaker.UI.MVVM._ConsoleView.NewGame.Story.NewGamePhaseStoryScenarioSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger m_Art /* Kingmaker.UI.LevelUp.CharBPortraitChanger */;
    [SerializeField] public object m_SelectorStoryText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DlcRequiredText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_SelectionScroll /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_DescriptionScroll /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::UnityEngine.GameObject m_LastAzlantiObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_LastAzlantiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_LastAzlantiText /* TMPro.TextMeshProUGUI */;
}

}

