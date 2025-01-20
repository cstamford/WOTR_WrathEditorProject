using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat {

public class TacticalCombatLeaderBaseView {
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_PortraitImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Slider m_ManaSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_ManaText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NameText /* TMPro.TextMeshProUGUI */;
}

}

