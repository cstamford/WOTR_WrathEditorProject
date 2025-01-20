using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance {

public class CharInfoEnergyResistanceView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelInclusion /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NoDataMessage /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Transform m_NoDataMessageContainer /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_EntriesWidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistanceEntryPCView m_EntryView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.EnergyResistance.CharInfoEnergyResistanceEntryPCView */;
}

}

