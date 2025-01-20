using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Abilities {

public class ExpandableTitleView {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ExpandButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.Transform m_ExpandArrow /* UnityEngine.Transform */;
    [SerializeField] public bool m_HasNavigation /* System.Boolean */;
    [SerializeField] public object m_ConsoleFocusButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_LayoutSettings /* Owlcat.Runtime.UI.VirtualListSystem.ElementSettings.VirtualListLayoutElementSettings */;
}

}

