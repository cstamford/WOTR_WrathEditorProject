using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.SaveLoad {

public class SaveSlotView {
    [SerializeField] public bool m_IsDetailedView /* System.Boolean */;
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LocationLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SaveDateTimeLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TimeInGameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DlcRequiredLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_ScreenshotImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::UnityEngine.GameObject m_AutoSaveMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_QuickSaveMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_ReadOnlyMark /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveLoadPortraitPCView m_PortraitPrefab /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveLoadPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListMvvm /* Kingmaker.UI.Common.WidgetListMVVM */;
}

}

