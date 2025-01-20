using Kingmaker.UI.Kingdom;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Settlement {

public class SettlementBuildingItem : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescriptionLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.UI.Image m_SlotsImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_UpdateImage /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_Timer /* UnityEngine.GameObject */;
    [SerializeField] public object m_TimerLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIResources m_Resources /* Kingmaker.UI.Kingdom.KingdomUIResources */;
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

