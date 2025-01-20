using Kingmaker.UI.Kingdom;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.KingdomRaven {

public class KingdomRavenEventItem : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_TitleArrow /* UnityEngine.RectTransform */;
    [SerializeField] public object m_Resolution /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Info /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_CritInfo /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color m_DefaultColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_ExpandContent /* UnityEngine.CanvasGroup */;
    [SerializeField] public object m_Solution /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Portrait /* UnityEngine.UI.Image */;
    [SerializeField] public object m_BPOneTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BPPerTurn /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_StatContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomStatContentStatsStat m_StatPrefab /* Kingmaker.UI.Kingdom.KingdomStatContentStatsStat */;
    public int BaseSizeY /* System.Int32 */;
    public int ExpandSizeY /* System.Int32 */;
}

}

