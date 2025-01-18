using Kingmaker.UI;
using UnityEngine;

namespace Kingmaker.UI.Dialog {

public class DialogCurrentPart : MonoBehaviour {
    public CanvasGroup ViewGroup /* UnityEngine.CanvasGroup */;
    public RectTransform ViewRoot /* UnityEngine.RectTransform */;
    public object ViewScroll /* Kingmaker.UI.Common.ScrollRectExtended */;
    public GameObject AnswersPanel /* UnityEngine.GameObject */;
    public TempOptionUI CueAnswer /* Kingmaker.UI.Dialog.TempOptionUI */;
    public object DialogPhrase /* TMPro.TextMeshProUGUI */;
    public DialogNotificationPhrase NotificationPhrase /* Kingmaker.UI.DialogNotificationPhrase */;
}

}

