using Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat {

public class TacticalCombatUnitActionBarConsoleView : global::Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.TacticalCombatUnitActionBarBaseView {
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::UnityEngine.GameObject m_SpellNameGroup /* UnityEngine.GameObject */;
    [SerializeField] public object m_SpellNameLabel /* TMPro.TextMeshProUGUI */;
    public object CanHold /* UniRx.BoolReactiveProperty */;
}

}

