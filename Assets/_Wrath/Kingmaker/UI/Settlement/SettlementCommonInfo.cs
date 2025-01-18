using System;
using UnityEngine;

namespace Kingmaker.UI.Settlement {

public class SettlementCommonInfo : MonoBehaviour {
    public int ShowPosX /* System.Int32 */;
    public int HidePosX /* System.Int32 */;
    public float AnimTime /* System.Single */;
    [SerializeField] public SettlementCommonInfo.Content m_Content /* Kingmaker.UI.Settlement.Content */;

    public class Content {
        public SettlementBuildingItem BuildingItem /* Kingmaker.UI.Settlement.SettlementBuildingItem */;
        public RectTransform BuildList /* UnityEngine.RectTransform */;
    }

}

}

