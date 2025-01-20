using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Kingdom.KingdomInfo {

public class KingdomStatView {
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_StatName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Rank /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ToRankUpValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_ProgressBar /* UnityEngine.UI.Slider */;
}

}

