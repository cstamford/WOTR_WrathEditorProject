using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarWeaponBaseView {
    [SerializeField] public global::UnityEngine.UI.Image m_BackIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_EmptyIcon /* UnityEngine.GameObject */;
    [SerializeField] public object m_BarButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.RectTransform m_WeaponSetContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponSetPCView> m_SetsViews /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponSetPCView> */;
}

}

