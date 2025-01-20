using Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.TacticalCombat {

public class TacticalCombatActionBarSlotConsoleView : global::Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.TacticalCombatActionBarSlotBaseView {
    [SerializeField] public object m_MainButtonState /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_CountSelectableState /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public object m_ConvertSelectableState /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public object m_FocusButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_ConvertCanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
}

}

