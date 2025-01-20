using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat {

public class LeaderCardPCView : global::Kingmaker.UI.MVVM._PCView.TacticalCombat.LeaderCardBaseView {
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillsPCView m_SkillsPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderStatsPCView m_StatsPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderStatsPCView */;
}

}

