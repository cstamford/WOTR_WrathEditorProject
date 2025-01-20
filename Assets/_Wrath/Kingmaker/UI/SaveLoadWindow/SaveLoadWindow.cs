using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class SaveLoadWindow : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_TableBackground /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_Header /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.RectTransform m_Bookmark /* UnityEngine.RectTransform */;
    [SerializeField] public SaveField m_SaveField /* .SaveField */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.ListOfSaves m_SavesList /* Kingmaker.UI.SaveLoadWindow.ListOfSaves */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonLoad /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonSave /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_DetailsSection /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_EmptyDetailsSection /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LocationLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SaveDateTimeLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TimeInGameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescriptionLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_ScreenshotImage /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.SaveLoadPortraits m_Portraits /* Kingmaker.UI.SaveLoadWindow.SaveLoadPortraits */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.SaveSlotMarkType m_MarkType /* Kingmaker.UI.SaveLoadWindow.SaveSlotMarkType */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonSaveLoad /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonDelete /* UnityEngine.UI.Button */;
}

}

