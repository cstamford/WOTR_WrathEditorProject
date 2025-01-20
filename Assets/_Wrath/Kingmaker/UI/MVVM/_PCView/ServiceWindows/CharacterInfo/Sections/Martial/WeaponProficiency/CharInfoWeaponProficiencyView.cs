using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency {

public class CharInfoWeaponProficiencyView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_ProficienciesWidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyEntryPCView m_ProficiencyEntry /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.WeaponProficiency.CharInfoWeaponProficiencyEntryPCView */;
    [SerializeField] public object m_NoDataMessage /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Transform m_NoDataMessageContainer /* UnityEngine.Transform */;
}

}

