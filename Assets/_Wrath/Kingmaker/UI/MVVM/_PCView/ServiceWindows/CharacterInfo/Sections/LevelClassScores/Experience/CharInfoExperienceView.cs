using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.Experience {

public class CharInfoExperienceView {
    [SerializeField] public object m_ExperienceLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Level /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ExpValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_ExpSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Image m_NegativeLevel /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_NotPetContainer /* UnityEngine.GameObject */;
}

}

