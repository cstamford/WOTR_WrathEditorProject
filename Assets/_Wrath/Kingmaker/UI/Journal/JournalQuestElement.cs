using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestElement : global::UnityEngine.MonoBehaviour {
    public object Description /* TMPro.TextMeshProUGUI */;
    public object Header /* TMPro.TextMeshProUGUI */;
    public object CompletionText /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.UI.Image FailWax /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image CompliteWax /* UnityEngine.UI.Image */;
    public global::UnityEngine.GameObject TimeToFailBlock /* UnityEngine.GameObject */;
    public object TimeToFailLabel /* TMPro.TextMeshProUGUI */;
    public global::Kingmaker.UI.Common.ScrollRectExtended ObjectiveConent /* Kingmaker.UI.Common.ScrollRectExtended */;
    public global::Kingmaker.UI.Journal.JournalQuestObjective QuestObjective /* Kingmaker.UI.Journal.JournalQuestObjective */;
}

}

