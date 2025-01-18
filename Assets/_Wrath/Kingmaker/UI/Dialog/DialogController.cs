using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Dialog {

public class DialogController : MonoBehaviour {
    public DialogCurrentPart CurrentPart /* Kingmaker.UI.Dialog.DialogCurrentPart */;
    public DialogHistoryEntity HistoryEntity /* Kingmaker.UI.Dialog.DialogHistoryEntity */;
    public DialogueSystemButton SystemButton /* Kingmaker.UI.Dialog.DialogueSystemButton */;
    public Transform History /* UnityEngine.Transform */;
    public Image SpeakerPortait /* UnityEngine.UI.Image */;
    public object SpeakerName /* TMPro.TextMeshProUGUI */;
    public Image SpeakerHolder /* UnityEngine.UI.Image */;
    public Image AnswererPortait /* UnityEngine.UI.Image */;
    public object AnswererName /* TMPro.TextMeshProUGUI */;
    public int HidePosY /* System.Int32 */;
    public int ShowPosY /* System.Int32 */;
    public float AnimTime /* System.Single */;
}

}

