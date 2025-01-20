using Kingmaker.UI.LevelUp;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait {

public class CharInfoNameAndPortraitView {
    [SerializeField] public object m_NameField /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger m_Portrait /* Kingmaker.UI.LevelUp.CharBPortraitChanger */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints.CharInfoHitPointsPCView m_HitPointsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.HitPoints.CharInfoHitPointsPCView */;
    [SerializeField] public object m_Size /* Kingmaker.Enums.PortraitType */;
    [SerializeField] public object m_MythicName /* TMPro.TextMeshProUGUI */;
}

}

