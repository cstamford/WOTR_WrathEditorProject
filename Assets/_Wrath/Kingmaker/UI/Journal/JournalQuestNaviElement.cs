using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Journal {

public class JournalQuestNaviElement : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_ActiveHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_ActiveBackground /* UnityEngine.GameObject */;
    [SerializeField] public object m_NonActiveHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_NonActiveBackground /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_Fail /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Complite /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_NeedToAttention /* UnityEngine.UI.Image */;
}

}

