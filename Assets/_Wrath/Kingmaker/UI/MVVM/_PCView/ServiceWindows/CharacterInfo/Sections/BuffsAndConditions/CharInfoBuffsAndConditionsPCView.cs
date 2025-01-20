using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.BuffsAndConditions {

public class CharInfoBuffsAndConditionsPCView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_NoBuffsContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_NoBuffsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoFeatureGroupPCView m_WidgetEntityView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Abilities.CharInfoFeatureGroupPCView */;
}

}

