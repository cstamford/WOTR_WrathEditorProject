using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarGroupPCView {
    [SerializeField] public object m_SwitchButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_GroupNameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_SlotContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarBaseSlotPCView m_Slot /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarBaseSlotPCView */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.RectTransform> m_TogglableChildren /* System.Collections.Generic.List<UnityEngine.RectTransform> */;
}

}

