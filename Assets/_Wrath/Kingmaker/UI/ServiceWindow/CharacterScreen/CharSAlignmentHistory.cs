using Kingmaker.UI.Common;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSAlignmentHistory : global::Kingmaker.UI.Common.UISection {
    public object ShiftsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public int m_HistoryRecordsNumber /* System.Int32 */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryRecord m_HistoryRecordPrefab /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryRecord */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryRecord> m_HistoryBlocks /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentHistoryRecord> */;
    [SerializeField] public global::UnityEngine.Transform m_HistoryRecordsBox /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.UI.Scrollbar m_HistoryScrollbar /* UnityEngine.UI.Scrollbar */;
}

}

