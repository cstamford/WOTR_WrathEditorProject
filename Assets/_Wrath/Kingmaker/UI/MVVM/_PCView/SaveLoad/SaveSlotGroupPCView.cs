using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.SaveLoad {

public class SaveSlotGroupPCView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotPCView m_SaveSlotPrefab /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListMvvm /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.Common.ExpandableElement m_ExpandableElement /* Kingmaker.UI.Common.ExpandableElement */;
    [SerializeField] public object m_LayoutSettings /* Owlcat.Runtime.UI.VirtualListSystem.ElementSettings.VirtualListLayoutElementSettings */;
}

}

