using Kingmaker.UI;
using Kingmaker.UI.MVVM._PCView.ActionBar;
using Kingmaker.UI.MVVM._PCView.ChangeVisual;
using Kingmaker.UI.MVVM._PCView.CharGen;
using Kingmaker.UI.MVVM._PCView.CombatLog;
using Kingmaker.UI.MVVM._PCView.Common;
using Kingmaker.UI.MVVM._PCView.Common.MessageModal;
using Kingmaker.UI.MVVM._PCView.Dialog;
using Kingmaker.UI.MVVM._PCView.Formation;
using Kingmaker.UI.MVVM._PCView.GameOver;
using Kingmaker.UI.MVVM._PCView.GroupChanger;
using Kingmaker.UI.MVVM._PCView.IngameMenu;
using Kingmaker.UI.MVVM._PCView.Inspect;
using Kingmaker.UI.MVVM._PCView.Loot;
using Kingmaker.UI.MVVM._PCView.Modificators;
using Kingmaker.UI.MVVM._PCView.Party;
using Kingmaker.UI.MVVM._PCView.Rest;
using Kingmaker.UI.MVVM._PCView.ServiceWindows;
using Kingmaker.UI.MVVM._PCView.Subtitle;
using Kingmaker.UI.MVVM._PCView.Transition;
using Kingmaker.UI.MVVM._PCView.Vendor;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.InGame {

public class InGameStaticPartPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.ServiceWindowsPCView m_ServiceWindowsPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.ServiceWindowsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Loot.LootContextPCView m_LootContextPCView /* Kingmaker.UI.MVVM._PCView.Loot.LootContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.DialogContextPCView m_DialogContextPCView /* Kingmaker.UI.MVVM._PCView.Dialog.DialogContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.CharGenContextPCView m_CharGenContextPCView /* Kingmaker.UI.MVVM._PCView.CharGen.CharGenContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GroupChanger.GroupChangerContextPCView m_GroupChangerContextPCView /* Kingmaker.UI.MVVM._PCView.GroupChanger.GroupChangerContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestContextPCView m_RestContextPCView /* Kingmaker.UI.MVVM._PCView.Rest.RestContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Inspect.InspectPCView m_InspectPCView /* Kingmaker.UI.MVVM._PCView.Inspect.InspectPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CombatLog.CombatLogPCView m_CombatLogPCView /* Kingmaker.UI.MVVM._PCView.CombatLog.CombatLogPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.IngameMenu.IngameMenuPCView m_IngameMenuPCView /* Kingmaker.UI.MVVM._PCView.IngameMenu.IngameMenuPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.PartyPCView m_PartyPCView /* Kingmaker.UI.MVVM._PCView.Party.PartyPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarPCView m_ActionBarPCView /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Transition.TransitionPCView m_TransitionPCView /* Kingmaker.UI.MVVM._PCView.Transition.TransitionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Formation.FormationPCView m_FormationPCView /* Kingmaker.UI.MVVM._PCView.Formation.FormationPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Vendor.VendorPCView m_VendorPCView /* Kingmaker.UI.MVVM._PCView.Vendor.VendorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GameOver.GameOverPCView m_GameOverPCView /* Kingmaker.UI.MVVM._PCView.GameOver.GameOverPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.MessageModal.SkipTimePCView m_SkipTimePCView /* Kingmaker.UI.MVVM._PCView.Common.MessageModal.SkipTimePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Subtitle.SubtitleView m_SubtitleView /* Kingmaker.UI.MVVM._PCView.Subtitle.SubtitleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.EtudeProgressBarView m_EtudeProgressBarView /* Kingmaker.UI.MVVM._PCView.Common.EtudeProgressBarView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Modificators.ModificatorsPCView m_ModificatorsPCView /* Kingmaker.UI.MVVM._PCView.Modificators.ModificatorsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualPCView m_ChangeVisualPCView /* Kingmaker.UI.MVVM._PCView.ChangeVisual.ChangeVisualPCView */;
    [SerializeField] public global::Kingmaker.UI.PauseToggle m_PauseToggle /* Kingmaker.UI.PauseToggle */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.MessageModal.BlurFadeoutView m_BlurFadeoutView /* Kingmaker.UI.MVVM._PCView.Common.MessageModal.BlurFadeoutView */;
    [SerializeField] public global::UnityEngine.Transform m_ParentInDungeonGameOverPC /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_ParentDungeonChooseBoonPC /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_ParentMapIslandsPC /* UnityEngine.Transform */;
}

}

