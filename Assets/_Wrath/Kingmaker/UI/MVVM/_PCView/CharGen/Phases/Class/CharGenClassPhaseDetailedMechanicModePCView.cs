using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class {

public class CharGenClassPhaseDetailedMechanicModePCView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::UnityEngine.RectTransform TargetSizeDollTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.UnitProgressionPCView m_UnitProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.UnitProgressionPCView */;
    [SerializeField] public object m_ClassName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClassDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassMartialStatsView m_MartialStatsView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassMartialStatsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassCasterStatsView m_CasterStatsView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassCasterStatsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassSkillsView m_SkillsView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenClassSkillsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenAutoLevelupButtonPCView m_AutoLevelupButtonView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenAutoLevelupButtonPCView */;
}

}

