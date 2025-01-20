using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo {

public class ArmySquadsView {
    [SerializeField] public object m_MovementPointsText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MoraleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DangerText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.MonoBehaviour m_ArmySizeHolder /* UnityEngine.MonoBehaviour */;
    [SerializeField] public object m_ArmySizeText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PerceptionSizeText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoSquadView> m_Squads /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmyInfoSquadView> */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmySquadsSplitView m_SplitView /* Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo.ArmySquadsSplitView */;
}

}

