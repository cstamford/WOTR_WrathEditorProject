using Kingmaker.UI.Common;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSAlignment : global::Kingmaker.UI.Common.UISection {
    [SerializeField] public object m_MainLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Transform m_SectorsArea /* UnityEngine.Transform */;
    [SerializeField] public int m_HistoryRecordsNumber /* System.Int32 */;
    [SerializeField] public global::UnityEngine.Transform m_PointsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryPoint m_HistoryPointPrefab /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryPoint */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryPoint> m_HistoryPoints /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryPoint> */;
}

}

