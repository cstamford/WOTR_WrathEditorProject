using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.NewGame.Difficulty;
using Kingmaker.UI.MVVM._PCView.NewGame.Menu;
using Kingmaker.UI.MVVM._PCView.NewGame.Story;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.NewGame {

public class NewGamePCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.NewGame.Menu.NewGameMenuSelectorPCView m_MenuSelectorView /* Kingmaker.UI.MVVM._PCView.NewGame.Menu.NewGameMenuSelectorPCView */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.NewGame.Story.NewGamePhaseStoryPCView m_StoryPCView /* Kingmaker.UI.MVVM._PCView.NewGame.Story.NewGamePhaseStoryPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.NewGame.Difficulty.NewGamePhaseDifficultyPCView m_DifficultyPCView /* Kingmaker.UI.MVVM._PCView.NewGame.Difficulty.NewGamePhaseDifficultyPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.NewGame.NewGamePhaseSaveInjectorPCView m_SaveInjectorView /* Kingmaker.UI.MVVM._PCView.NewGame.NewGamePhaseSaveInjectorPCView */;
    [SerializeField] public object m_BackButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_MenuTitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BackButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NextButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

