using Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp {

public class LeaderLevelUpView {
    [SerializeField] public object m_HeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_GuaranteedAbilityText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseAbilityText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NextLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderCommonView m_CommonView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderCommonView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp.LeaderLevelUpStatsView m_StatsView /* Kingmaker.UI.MVVM._PCView.Crusade.LeaderLevelUp.LeaderLevelUpStatsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillsView m_SkillsView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillsView */;
    [SerializeField] public global::UnityEngine.GameObject m_GuaranteedSkillBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillView m_GuaranteedSkillView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillView m_SkillView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyLeaderSkillView */;
    [SerializeField] public global::UnityEngine.RectTransform m_SelectedSkillContainer /* UnityEngine.RectTransform */;
}

}

