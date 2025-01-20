using Kingmaker.UI.Constructor;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar {

public class ActionBarSlotPCView : global::Kingmaker.UI.MVVM._PCView.TacticalCombat.ActionBar.TacticalCombatActionBarSlotBaseView {
    [SerializeField] public global::UnityEngine.GameObject m_EmptySlotObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_SlotObject /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Constructor.ButtonPF m_Button /* Kingmaker.UI.Constructor.ButtonPF */;
    [SerializeField] public global::UnityEngine.GameObject m_HotKeyObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_HotKeyText /* TMPro.TextMeshProUGUI */;
}

}

