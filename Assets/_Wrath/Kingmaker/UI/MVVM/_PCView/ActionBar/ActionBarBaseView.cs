using Kingmaker.UI.TurnBasedMode;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarBaseView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarVisibilityStateBaseView m_VisibilityStateView /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarVisibilityStateBaseView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponBaseView m_WeaponView /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarWeaponBaseView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.KineticBurnPCView m_KineticBurnView /* Kingmaker.UI.MVVM._PCView.ActionBar.KineticBurnPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.LocustSwarmPCView m_LocustSwarmView /* Kingmaker.UI.MVVM._PCView.ActionBar.LocustSwarmPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.AutoUseAbilityBaseView m_AutoUseAbilityView /* Kingmaker.UI.MVVM._PCView.ActionBar.AutoUseAbilityBaseView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ControlCharactersPCView m_ControlCharactersView /* Kingmaker.UI.MVVM._PCView.ActionBar.ControlCharactersPCView */;
    [SerializeField] public global::Kingmaker.UI.TurnBasedMode.PredictionPanelBaseView m_PredictionPanelView /* Kingmaker.UI.TurnBasedMode.PredictionPanelBaseView */;
    [SerializeField] public global::UnityEngine.RectTransform m_MainSlotsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public object m_PageLabel /* TMPro.TextMeshProUGUI */;
}

}

