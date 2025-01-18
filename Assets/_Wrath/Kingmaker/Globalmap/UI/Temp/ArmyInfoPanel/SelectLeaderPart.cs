using Kingmaker.UI.GlobalMap.Temp;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.Globalmap.UI.Temp.ArmyInfoPanel {

public class SelectLeaderPart : MonoBehaviour {
    [SerializeField] public Button m_RecruiteButton /* UnityEngine.UI.Button */;
    [SerializeField] public object m_RecruiteLeadText /* TMPro.TMP_Text */;
    [SerializeField] public LeaderUIItem m_Prefab /* Kingmaker.UI.GlobalMap.Temp.LeaderUIItem */;
    [SerializeField] public Transform m_Parent /* UnityEngine.Transform */;
    [SerializeField] public float m_ItemScale /* System.Single */;
    [SerializeField] public Button m_ReturnButton /* UnityEngine.UI.Button */;
}

}

