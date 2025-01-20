using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.Kingdom.Settlements {

public class SettlementBuildingWindow {
    [SerializeField] public global::Kingmaker.Kingdom.Settlements.SettlementBuildingWindow.SellBlock m_SellBlock /* Kingmaker.Kingdom.Settlements.SellBlock */;
    [SerializeField] public global::Kingmaker.Kingdom.Settlements.SettlementBuildingWindow.UpdateBlock m_UpdateBlock /* Kingmaker.Kingdom.Settlements.UpdateBlock */;

    public class SellBlock {
        public global::UnityEngine.GameObject Container /* UnityEngine.GameObject */;
        public global::UnityEngine.UI.Button SellBuild /* UnityEngine.UI.Button */;
        public object Earned /* TMPro.TextMeshProUGUI */;
        public global::UnityEngine.UI.Slider SellBar /* UnityEngine.UI.Slider */;
        public global::UnityEngine.UI.Button SellCancelButton /* UnityEngine.UI.Button */;
    }

    public class UpdateBlock {
        public object Cost /* TMPro.TextMeshProUGUI */;
        public global::UnityEngine.GameObject Container /* UnityEngine.GameObject */;
        public global::UnityEngine.UI.Button UpdateButton /* UnityEngine.UI.Button */;
    }

}

}

