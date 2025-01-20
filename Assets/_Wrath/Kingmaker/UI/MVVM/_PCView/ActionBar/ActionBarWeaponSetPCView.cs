using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarWeaponSetPCView {
    [SerializeField] public object m_SetIndexText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MainButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponSetItemBaseView m_PrimarySlot /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponSetItemBaseView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponSetItemBaseView m_SecondarySlot /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponSetItemBaseView */;
    [SerializeField] public object m_GripButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

