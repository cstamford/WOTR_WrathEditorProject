using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.BugReport.BugReportDrawing {

public class BugReportDrawingWindow : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.RectTransform MainCanvas /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform BackgroundRectTransform /* UnityEngine.RectTransform */;
    public global::Kingmaker.UI.BugReport.BugReportDrawing.BugreportScreenSaveClass BugreportScreenSaveClass /* Kingmaker.UI.BugReport.BugReportDrawing.BugreportScreenSaveClass */;
    public global::UnityEngine.UI.Image ScreenShotImage /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image DrawingImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_HeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClearButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SaveButtonText /* TMPro.TextMeshProUGUI */;
}

}

