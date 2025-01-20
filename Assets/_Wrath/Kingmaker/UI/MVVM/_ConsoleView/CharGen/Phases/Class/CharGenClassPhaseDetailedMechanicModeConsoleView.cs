using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Progression.Main;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Class {

public class CharGenClassPhaseDetailedMechanicModeConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Progression.Main.UnitProgressionConsoleView m_UnitProgressionView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Progression.Main.UnitProgressionConsoleView */;
    [SerializeField] public object m_ClassName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClassDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassMartialStatsView m_MartialStatsView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassMartialStatsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassCasterStatsView m_CasterStatsView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassCasterStatsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassSkillsView m_SkillsView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassSkillsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Class.CharGenAutoLevelupButtonConsoleView m_AutoLevelupButtonView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Class.CharGenAutoLevelupButtonConsoleView */;
}

}

