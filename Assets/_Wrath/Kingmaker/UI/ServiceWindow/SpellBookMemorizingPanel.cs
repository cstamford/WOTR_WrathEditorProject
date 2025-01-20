using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookMemorizingPanel : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Transform m_CommonSlotsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_SpecialSlotsContainer /* UnityEngine.Transform */;
    [SerializeField] public object m_SlotsSubstituteText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelMemorizedSpells /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelSpecialSlots /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_SpecialSlotsBackground /* UnityEngine.UI.Image */;
    [SerializeField] public object m_NeedToSleepText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_NeedToSleepPlace /* UnityEngine.GameObject */;
}

}

