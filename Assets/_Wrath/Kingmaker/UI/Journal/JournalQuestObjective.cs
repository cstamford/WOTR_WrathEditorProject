using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestObjective : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.Journal.JournalQuestAddendum Addendum /* Kingmaker.UI.Journal.JournalQuestAddendum */;
    public global::UnityEngine.RectTransform AddendumContent /* UnityEngine.RectTransform */;
    public global::UnityEngine.GameObject CollapseObject /* UnityEngine.GameObject */;
    public object Description /* TMPro.TextMeshProUGUI */;
    public object Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_CollapseButton /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Image m_Complite /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Fail /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ActiveLayer /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_NeedToAttention /* UnityEngine.UI.Image */;
    [SerializeField] public object m_TimeToFail /* TMPro.TextMeshProUGUI */;
}

}

