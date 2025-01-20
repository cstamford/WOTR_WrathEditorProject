using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo {

public class ArmySquadsConsoleView {
    [SerializeField] public object m_MovementButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MoraleButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_DangerButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_ArmySizeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_PerceptionButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoSquadConsoleView> Squads /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmyInfoSquadConsoleView> */;
}

}

