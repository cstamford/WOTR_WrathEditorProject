using Kingmaker.UI;
using Kingmaker.UI.MVVM._ConsoleView.ActionBar;
using Kingmaker.UI.MVVM._ConsoleView.ChangeVisual;
using Kingmaker.UI.MVVM._ConsoleView.CharGen;
using Kingmaker.UI.MVVM._ConsoleView.CombatLog;
using Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal;
using Kingmaker.UI.MVVM._ConsoleView.Dialog;
using Kingmaker.UI.MVVM._ConsoleView.Formation;
using Kingmaker.UI.MVVM._ConsoleView.GameOver;
using Kingmaker.UI.MVVM._ConsoleView.GroupChanger;
using Kingmaker.UI.MVVM._ConsoleView.IngameMenu;
using Kingmaker.UI.MVVM._ConsoleView.Loot;
using Kingmaker.UI.MVVM._ConsoleView.Modificators;
using Kingmaker.UI.MVVM._ConsoleView.Party;
using Kingmaker.UI.MVVM._ConsoleView.Rest;
using Kingmaker.UI.MVVM._ConsoleView.Retrain;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows;
using Kingmaker.UI.MVVM._ConsoleView.Transition;
using Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode;
using Kingmaker.UI.MVVM._ConsoleView.Vendor;
using Kingmaker.UI.MVVM._PCView.Common;
using Kingmaker.UI.MVVM._PCView.Common.MessageModal;
using Kingmaker.UI.MVVM._PCView.Subtitle;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.InGame {

public class InGameStaticPartConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.ServiceWindowsConsoleView m_ServiceWindowsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.ServiceWindowsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Loot.LootContextConsoleView m_LootContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Loot.LootContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dialog.DialogContextConsoleView m_DialogContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Dialog.DialogContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenContextConsoleView m_CharGenContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GroupChanger.GroupChangerContextConsoleView m_GroupChangerContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GroupChanger.GroupChangerContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.IngameMenu.IngameMenuConsoleView m_IngameMenuConsoleView /* Kingmaker.UI.MVVM._ConsoleView.IngameMenu.IngameMenuConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.IngameMenu.IngameMenuCardsConsoleView m_IngameMenuCartConsoleView /* Kingmaker.UI.MVVM._ConsoleView.IngameMenu.IngameMenuCardsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Party.PartyCardsConsoleView m_PartyHudConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Party.PartyCardsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestContextConsoleView m_RestContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorConsoleView m_VendorConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogConsoleView m_CombatLogConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ActionBar.ActionBarConsoleView m_ActionBarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ActionBar.ActionBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionConsoleView m_TransitionConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Formation.FormationConsoleView m_FormationConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Formation.FormationConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Party.PartyConsoleView m_PartyConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Party.PartyConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Subtitle.SubtitleView m_SubtitleView /* Kingmaker.UI.MVVM._PCView.Subtitle.SubtitleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Retrain.RetrainContextConsoleView m_RetrainView /* Kingmaker.UI.MVVM._ConsoleView.Retrain.RetrainContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.EtudeProgressBarView m_EtudeProgressBarView /* Kingmaker.UI.MVVM._PCView.Common.EtudeProgressBarView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode.InitiativeTrackerVerticalConsoleView m_InitiativeTrackerVerticalConsoleView /* Kingmaker.UI.MVVM._ConsoleView.TurnBasedMode.InitiativeTrackerVerticalConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.GameOver.GameOverConsoleView m_GameOverConsoleView /* Kingmaker.UI.MVVM._ConsoleView.GameOver.GameOverConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Modificators.ModificatorsConsoleView m_ModificatorsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Modificators.ModificatorsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.PauseToggle m_PauseToggle /* Kingmaker.UI.PauseToggle */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal.SkipTimeConsoleView m_SkipTimeConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal.SkipTimeConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualConsoleView m_ChangeVisualConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ChangeVisual.ChangeVisualConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.MessageModal.BlurFadeoutView m_BlurFadeoutView /* Kingmaker.UI.MVVM._PCView.Common.MessageModal.BlurFadeoutView */;
    [SerializeField] public global::UnityEngine.Transform m_ParentInDungeonGameOverConsole /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_ParentDungeonChooseBoonConsole /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_ParentMapIslandsConsole /* UnityEngine.Transform */;
    public object HighlightedUnit /* UniRx.ReactiveProperty */;
}

}

