using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomEventPossibleResultItem : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_TitleArrow /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_ExpandContent /* UnityEngine.GameObject */;
    [SerializeField] public object m_Solution /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPOneTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerTurn /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_BPContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.RectTransform m_StatContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
}

}

