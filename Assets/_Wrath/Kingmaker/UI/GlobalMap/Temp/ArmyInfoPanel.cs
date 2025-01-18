using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Temp {

public class ArmyInfoPanel : MonoBehaviour {
    [SerializeField] public Canvas m_Canvas /* UnityEngine.Canvas */;
    [SerializeField] public Button m_CloseButton /* UnityEngine.UI.Button */;
    [SerializeField] public ArmyLeaderPart m_LeadPart /* Kingmaker.UI.GlobalMap.Temp.ArmyLeaderPart */;
    [SerializeField] public UnitsInfoPanelPart m_UnitsPart /* Kingmaker.UI.GlobalMap.Temp.UnitsInfoPanelPart */;
    [SerializeField] public ArmyStatsPanelPart m_ArmyStatsPart /* Kingmaker.UI.GlobalMap.Temp.ArmyStatsPanelPart */;
}

}

