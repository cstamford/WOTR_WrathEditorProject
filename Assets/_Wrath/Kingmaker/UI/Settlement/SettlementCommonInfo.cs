using System;
using UnityEngine;

namespace Kingmaker.UI.Settlement {

public class SettlementCommonInfo : global::UnityEngine.MonoBehaviour {
    public int ShowPosX /* System.Int32 */;
    public int HidePosX /* System.Int32 */;
    public float AnimTime /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.Settlement.SettlementCommonInfo.Content m_Content /* Kingmaker.UI.Settlement.Content */;

    public class Content {
        public global::Kingmaker.UI.Settlement.SettlementBuildingItem BuildingItem /* Kingmaker.UI.Settlement.SettlementBuildingItem */;
        public global::UnityEngine.RectTransform BuildList /* UnityEngine.RectTransform */;
    }

}

}

