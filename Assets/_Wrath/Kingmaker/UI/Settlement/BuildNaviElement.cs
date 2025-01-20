using System;
using UnityEngine;

namespace Kingmaker.UI.Settlement {

public class BuildNaviElement : global::Kingmaker.UI.Settlement.SettlementNaviElement {
    [SerializeField] public global::Kingmaker.UI.Settlement.SettlementCommonInfo m_BuildList /* Kingmaker.UI.Settlement.SettlementCommonInfo */;
    public int SelectSizeX /* System.Int32 */;
    public int UnselectSizeX /* System.Int32 */;
    [SerializeField] public global::UnityEngine.GameObject m_Slots /* UnityEngine.GameObject */;
    [SerializeField] public object m_SlotsLabel /* TMPro.TextMeshProUGUI */;
}

}

