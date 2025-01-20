using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar {

public class TacticalCombatActionBarSlotBaseView {
    [SerializeField] public object m_CountText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_SpellIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Disabled /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ActiveMark /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_CastingMark /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color m_DefaultColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_RunningColor /* UnityEngine.Color */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.TacticalCombatActionBarConvertedBaseView m_ConvertedView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.TacticalCombatActionBarConvertedBaseView */;
    [SerializeField] public object m_ConvertButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_ConvertChildImage /* UnityEngine.UI.Image */;
}

}

