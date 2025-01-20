using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat {

public class LeaderCardBaseView {
    [SerializeField] public object m_HeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_ExpSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_LevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ExpText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderCommonView m_CommonPCView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderCommonView */;
}

}

