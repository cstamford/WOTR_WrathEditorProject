using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUISettlementWindow : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Type /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_CanUpdate /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_UpgradeBlock /* UnityEngine.GameObject */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NaviTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NaviNext /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NaviPrev /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUISettlementWindowStats m_Stats /* Kingmaker.UI.Kingdom.KingdomUISettlementWindowStats */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUISettlementWindowBuilds m_Builds /* Kingmaker.UI.Kingdom.KingdomUISettlementWindowBuilds */;
    [SerializeField] public object m_Enter /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

