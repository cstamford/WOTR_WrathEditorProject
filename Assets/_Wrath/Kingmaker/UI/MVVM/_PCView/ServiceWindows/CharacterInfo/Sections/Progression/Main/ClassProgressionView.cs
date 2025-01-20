using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Spellbook;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Stats;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main {

public class ClassProgressionView {
    [SerializeField] public object m_ClassName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClassLevel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenStatView m_HPPerLevel /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.Mechanic.CharGenStatView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Stats.StatsProgressionView m_StatsProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Stats.StatsProgressionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Spellbook.SpellbookProgressionView m_SpellbookProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Spellbook.SpellbookProgressionView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListMvvm /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.ProgressionView m_ProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Progression.Main.ProgressionView */;
    [SerializeField] public global::Kingmaker.UI.Common.ExpandableElement m_ExpandableElement /* Kingmaker.UI.Common.ExpandableElement */;
}

}

