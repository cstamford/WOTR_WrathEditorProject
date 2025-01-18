using Kingmaker.Globalmap.UI.Temp.ArmyInfoPanel;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Temp {

public class ArmyLeaderPart : MonoBehaviour {
    [SerializeField] public LeadInfoPanelPart m_CurrentLeader /* Kingmaker.UI.GlobalMap.Temp.LeadInfoPanelPart */;
    [SerializeField] public SelectLeaderPart m_SelectLeaderPart /* Kingmaker.Globalmap.UI.Temp.ArmyInfoPanel.SelectLeaderPart */;
    [SerializeField] public Button m_DetachLeaderButton /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_SwitchLeaderButton /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_SetLeaderButton /* UnityEngine.UI.Button */;
}

}

