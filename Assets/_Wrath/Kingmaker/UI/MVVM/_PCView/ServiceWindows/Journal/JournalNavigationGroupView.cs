using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal {

public class JournalNavigationGroupView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.ExpandableElement m_MultiButton /* Kingmaker.UI.Common.ExpandableElement */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalNavigationGroupElementBaseView NavigationGroupElementViewPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalNavigationGroupElementBaseView */;
}

}

