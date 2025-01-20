using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities {

public class CharInfoAbilitiesConsoleView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_VirtualList /* Owlcat.Runtime.UI.VirtualListSystem.VirtualListVertical */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoFeatureConsoleView m_FeaturePrefab /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoFeatureConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities.ExpandableTitleView m_TitlePrefab /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities.ExpandableTitleView */;
    [SerializeField] public object m_SwitchHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public bool m_ExpandAll /* System.Boolean */;
    [SerializeField] public bool m_ExpandFirst /* System.Boolean */;
}

}

