using Kingmaker.UI;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class SaveSlotBase : global::Kingmaker.UI.DoubleClickableElement {
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LocationLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SaveDateTimeLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TimeInGameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_ScreenshotImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::UnityEngine.UI.Image m_BackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_SelectionImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.SaveSlotMarkType m_MarkType /* Kingmaker.UI.SaveLoadWindow.SaveSlotMarkType */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.SaveLoadPortraits m_Portraits /* Kingmaker.UI.SaveLoadWindow.SaveLoadPortraits */;
}

}

