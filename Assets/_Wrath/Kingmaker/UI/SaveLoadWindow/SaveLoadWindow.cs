using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class SaveLoadWindow : MonoBehaviour {
    [SerializeField] public FadeAnimator m_TableBackground /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public MoveAnimator m_Header /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public RectTransform m_Bookmark /* UnityEngine.RectTransform */;
    [SerializeField] public SaveField m_SaveField /* .SaveField */;
    [SerializeField] public ListOfSaves m_SavesList /* Kingmaker.UI.SaveLoadWindow.ListOfSaves */;
    [SerializeField] public Button m_ButtonLoad /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_ButtonSave /* UnityEngine.UI.Button */;
    [SerializeField] public CanvasGroup m_DetailsSection /* UnityEngine.CanvasGroup */;
    [SerializeField] public CanvasGroup m_EmptyDetailsSection /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LocationLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SaveDateTimeLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TimeInGameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescriptionLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RawImage m_ScreenshotImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public SaveLoadPortraits m_Portraits /* Kingmaker.UI.SaveLoadWindow.SaveLoadPortraits */;
    [SerializeField] public SaveSlotMarkType m_MarkType /* Kingmaker.UI.SaveLoadWindow.SaveSlotMarkType */;
    [SerializeField] public Button m_ButtonSaveLoad /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_ButtonDelete /* UnityEngine.UI.Button */;
}

}

