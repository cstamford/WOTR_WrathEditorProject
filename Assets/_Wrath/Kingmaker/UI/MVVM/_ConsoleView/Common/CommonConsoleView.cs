using Kingmaker.UI;
using Kingmaker.UI.MVVM._ConsoleView.ChoseControllerMode;
using Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal;
using Kingmaker.UI.MVVM._ConsoleView.ContextMenu;
using Kingmaker.UI.MVVM._ConsoleView.CounterWindow;
using Kingmaker.UI.MVVM._ConsoleView.EscMenu;
using Kingmaker.UI.MVVM._ConsoleView.PhotoMode;
using Kingmaker.UI.MVVM._ConsoleView.PhotoModeInstant;
using Kingmaker.UI.MVVM._ConsoleView.QuestNotification;
using Kingmaker.UI.MVVM._ConsoleView.SaveLoad;
using Kingmaker.UI.MVVM._ConsoleView.Settings;
using Kingmaker.UI.MVVM._ConsoleView.Tooltip;
using Kingmaker.UI.MVVM._ConsoleView.Tutorial;
using Kingmaker.UI.MVVM._PCView.GameOver;
using Kingmaker.UI.MVVM._PCView.LoadingScreen;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Common {

public class CommonConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChoseControllerMode.GamepadDisconnectedInGamepadModeWindowView m_GamepadDisconnectedInGamepadModeWindowView /* Kingmaker.UI.MVVM._ConsoleView.ChoseControllerMode.GamepadDisconnectedInGamepadModeWindowView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ChoseControllerMode.EngagementScreenView m_EngagementScreenView /* Kingmaker.UI.MVVM._ConsoleView.ChoseControllerMode.EngagementScreenView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal.MessageModalConsoleView m_MessageModalView /* Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal.MessageModalConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.LoadingScreen.LoadingScreenPCView m_LoadingScreenPCView /* Kingmaker.UI.MVVM._PCView.LoadingScreen.LoadingScreenPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CounterWindow.CounterWindowConsoleView m_CounterWindowConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CounterWindow.CounterWindowConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Tutorial.TutorialConsoleView m_TutorialConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Tutorial.TutorialConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Settings.SettingsConsoleView m_SettingsView /* Kingmaker.UI.MVVM._ConsoleView.Settings.SettingsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ContextMenu.ContextMenuConsoleView m_ContextMenuConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ContextMenu.ContextMenuConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ContextMenu.FullContextMenuConsoleView m_FullContextMenuConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ContextMenu.FullContextMenuConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Tooltip.TooltipContextConsoleView m_TooltipContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Tooltip.TooltipContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.QuestNotification.QuestNotificatorConsoleView m_QuestNotificatorConsoleView /* Kingmaker.UI.MVVM._ConsoleView.QuestNotification.QuestNotificatorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.SaveLoad.SaveLoadConsoleView m_SaveLoadConsoleView /* Kingmaker.UI.MVVM._ConsoleView.SaveLoad.SaveLoadConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.EscMenu.EscMenuContextConsoleView m_EscMenuConsoleView /* Kingmaker.UI.MVVM._ConsoleView.EscMenu.EscMenuContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.SaveLoad.SaveInjectorConsoleView m_SaveInjectorConsoleView /* Kingmaker.UI.MVVM._ConsoleView.SaveLoad.SaveInjectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GameOver.EndOfGameView m_EndOfGameView /* Kingmaker.UI.MVVM._PCView.GameOver.EndOfGameView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeConsoleView m_PhotoModeConsoleView /* Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.PhotoModeInstant.PhotoModeInstantConsoleView m_PhotoModeInstantConsoleView /* Kingmaker.UI.MVVM._ConsoleView.PhotoModeInstant.PhotoModeInstantConsoleView */;
    [SerializeField] public global::Kingmaker.UI.WarningsText m_WarningsText /* Kingmaker.UI.WarningsText */;
}

}

