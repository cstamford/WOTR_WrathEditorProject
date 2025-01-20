using Kingmaker.Globalmap.UI.Temp.ArmyInfoPanel;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Temp {

public class ArmyLeaderPart : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.GlobalMap.Temp.LeadInfoPanelPart m_CurrentLeader /* Kingmaker.UI.GlobalMap.Temp.LeadInfoPanelPart */;
    [SerializeField] public global::Kingmaker.Globalmap.UI.Temp.ArmyInfoPanel.SelectLeaderPart m_SelectLeaderPart /* Kingmaker.Globalmap.UI.Temp.ArmyInfoPanel.SelectLeaderPart */;
    [SerializeField] public global::UnityEngine.UI.Button m_DetachLeaderButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_SwitchLeaderButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_SetLeaderButton /* UnityEngine.UI.Button */;
}

}

