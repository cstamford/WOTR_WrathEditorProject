using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Temp {

public class LeadInfoPanelPart : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.GlobalMap.Temp.ExpSliderPart m_ExpSlider /* Kingmaker.UI.GlobalMap.Temp.ExpSliderPart */;
    [SerializeField] public global::UnityEngine.UI.Image m_LeaderAvatar /* UnityEngine.UI.Image */;
    [SerializeField] public object m_LeaderName /* TMPro.TMP_Text */;
    [SerializeField] public object m_ArmyName /* TMPro.TMP_Text */;
    [SerializeField] public object m_LeaderSkillsHeader /* TMPro.TMP_Text */;
    [SerializeField] public object m_LeaderManaField /* TMPro.TMP_Text */;
    [SerializeField] public global::UnityEngine.UI.ScrollRect m_SkillsScroll /* UnityEngine.UI.ScrollRect */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.Temp.SkillInfoItem m_SkillUIPrefab /* Kingmaker.UI.GlobalMap.Temp.SkillInfoItem */;
}

}

