using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestElement : MonoBehaviour {
    public object Description /* TMPro.TextMeshProUGUI */;
    public object Header /* TMPro.TextMeshProUGUI */;
    public object CompletionText /* TMPro.TextMeshProUGUI */;
    public Image FailWax /* UnityEngine.UI.Image */;
    public Image CompliteWax /* UnityEngine.UI.Image */;
    public GameObject TimeToFailBlock /* UnityEngine.GameObject */;
    public object TimeToFailLabel /* TMPro.TextMeshProUGUI */;
    public object ObjectiveConent /* Kingmaker.UI.Common.ScrollRectExtended */;
    public JournalQuestObjective QuestObjective /* Kingmaker.UI.Journal.JournalQuestObjective */;
}

}

