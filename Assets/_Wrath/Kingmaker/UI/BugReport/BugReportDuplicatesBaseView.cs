using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.BugReport {

public class BugReportDuplicatesBaseView {
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LoadingProcessText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.BugReport.BugDuplicateItemView m_WidgetEntityView /* Kingmaker.UI.BugReport.BugDuplicateItemView */;
}

}

