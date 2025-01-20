using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Dialog {

public class DialogController : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.Dialog.DialogCurrentPart CurrentPart /* Kingmaker.UI.Dialog.DialogCurrentPart */;
    public global::Kingmaker.UI.Dialog.DialogHistoryEntity HistoryEntity /* Kingmaker.UI.Dialog.DialogHistoryEntity */;
    public global::Kingmaker.UI.Dialog.DialogueSystemButton SystemButton /* Kingmaker.UI.Dialog.DialogueSystemButton */;
    public global::UnityEngine.Transform History /* UnityEngine.Transform */;
    public global::UnityEngine.UI.Image SpeakerPortait /* UnityEngine.UI.Image */;
    public object SpeakerName /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.UI.Image SpeakerHolder /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image AnswererPortait /* UnityEngine.UI.Image */;
    public object AnswererName /* TMPro.TextMeshProUGUI */;
    public int HidePosY /* System.Int32 */;
    public int ShowPosY /* System.Int32 */;
    public float AnimTime /* System.Single */;
}

}

