using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait {

public class CharGenMythicPortraitPhaseDetailedPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenPortraitTabSelectorPCView m_TabSelector /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenPortraitTabSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListDefaultGroups /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenMythicPortraitGroupPCView m_DefaultGroupPrefab /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenMythicPortraitGroupPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenCustomPortraitGroupPCView m_CustomPortraitGroup /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenCustomPortraitGroupPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_DefaultPortraitsContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CustomPortraitsContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenCustomPortraitCreatorPCView m_CustomPortraitCreatorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenCustomPortraitCreatorPCView */;
    [SerializeField] public object m_ChangePortraitButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ChangePortraitLabel /* TMPro.TextMeshProUGUI */;
}

}

