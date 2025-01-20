using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.NewGame.Difficulty;
using Kingmaker.UI.MVVM._ConsoleView.NewGame.Menu;
using Kingmaker.UI.MVVM._ConsoleView.NewGame.Story;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.NewGame {

public class NewGameConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.NewGame.Menu.NewGameMenuSelectorConsoleView m_MenuSelectorView /* Kingmaker.UI.MVVM._ConsoleView.NewGame.Menu.NewGameMenuSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.NewGame.Story.NewGamePhaseStoryConsoleView m_StoryView /* Kingmaker.UI.MVVM._ConsoleView.NewGame.Story.NewGamePhaseStoryConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.NewGame.Difficulty.NewGamePhaseDifficultyConsoleView m_DifficultyView /* Kingmaker.UI.MVVM._ConsoleView.NewGame.Difficulty.NewGamePhaseDifficultyConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.NewGame.NewGamePhaseSaveInjectorConsoleView m_SaveInjectorView /* Kingmaker.UI.MVVM._ConsoleView.NewGame.NewGamePhaseSaveInjectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_MenuTitleText /* TMPro.TextMeshProUGUI */;
}

}

