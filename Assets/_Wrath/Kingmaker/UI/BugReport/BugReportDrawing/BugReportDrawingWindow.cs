using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.BugReport.BugReportDrawing {

public class BugReportDrawingWindow : MonoBehaviour {
    public RectTransform MainCanvas /* UnityEngine.RectTransform */;
    public RectTransform BackgroundRectTransform /* UnityEngine.RectTransform */;
    public BugreportScreenSaveClass BugreportScreenSaveClass /* Kingmaker.UI.BugReport.BugReportDrawing.BugreportScreenSaveClass */;
    public Image ScreenShotImage /* UnityEngine.UI.Image */;
    public Image DrawingImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_HeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ClearButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SaveButtonText /* TMPro.TextMeshProUGUI */;
}

}

