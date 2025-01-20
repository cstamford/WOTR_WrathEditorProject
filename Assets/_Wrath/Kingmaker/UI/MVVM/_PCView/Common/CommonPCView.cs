using Kingmaker.Modding;
using Kingmaker.UI;
using Kingmaker.UI.MVVM._PCView.ChoseControllerMode;
using Kingmaker.UI.MVVM._PCView.Common.MessageModal;
using Kingmaker.UI.MVVM._PCView.ContextMenu;
using Kingmaker.UI.MVVM._PCView.CounterWindow;
using Kingmaker.UI.MVVM._PCView.EscMenu;
using Kingmaker.UI.MVVM._PCView.GameOver;
using Kingmaker.UI.MVVM._PCView.LoadingScreen;
using Kingmaker.UI.MVVM._PCView.PhotoMode;
using Kingmaker.UI.MVVM._PCView.PhotoModeInstant;
using Kingmaker.UI.MVVM._PCView.QuestNotification;
using Kingmaker.UI.MVVM._PCView.SaveLoad;
using Kingmaker.UI.MVVM._PCView.Settings;
using Kingmaker.UI.MVVM._PCView.Tooltip;
using Kingmaker.UI.MVVM._PCView.Tutorial;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Common {

public class CommonPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.EscMenu.EscMenuContextPCView m_EscMenuContextPCView /* Kingmaker.UI.MVVM._PCView.EscMenu.EscMenuContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Tooltip.TooltipContextPCView m_TooltipContextPCView /* Kingmaker.UI.MVVM._PCView.Tooltip.TooltipContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificatorPCView m_QuestNotificatorPCView /* Kingmaker.UI.MVVM._PCView.QuestNotification.QuestNotificatorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.LoadingScreen.LoadingScreenPCView m_LoadingScreenPCView /* Kingmaker.UI.MVVM._PCView.LoadingScreen.LoadingScreenPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Tutorial.TutorialPCView m_TutorialPCView /* Kingmaker.UI.MVVM._PCView.Tutorial.TutorialPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.MessageModal.MessageModalPCView m_MessageModalPCView /* Kingmaker.UI.MVVM._PCView.Common.MessageModal.MessageModalPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CounterWindow.CounterWindowPCView m_CounterWindowPCView /* Kingmaker.UI.MVVM._PCView.CounterWindow.CounterWindowPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ContextMenu.ContextMenuPCView m_ContextMenuPCView /* Kingmaker.UI.MVVM._PCView.ContextMenu.ContextMenuPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveLoadPCView m_SaveLoadPCView /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveLoadPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Settings.SettingsPCView m_SettingsPCView /* Kingmaker.UI.MVVM._PCView.Settings.SettingsPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GameOver.EndOfGameView m_EndOfGameView /* Kingmaker.UI.MVVM._PCView.GameOver.EndOfGameView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ChoseControllerMode.GamepadConnectedInKeyboardModeWindowView m_GamepadConnectedInKeyboardModeWindowView /* Kingmaker.UI.MVVM._PCView.ChoseControllerMode.GamepadConnectedInKeyboardModeWindowView */;
    [SerializeField] public global::Kingmaker.Modding.OwlcatModificationsWindow m_OwlcatModificationsWindow /* Kingmaker.Modding.OwlcatModificationsWindow */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveInjectorPCView m_SaveInjectorPCView /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveInjectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.PhotoMode.PhotoModePCView m_PhotoModePCView /* Kingmaker.UI.MVVM._PCView.PhotoMode.PhotoModePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.PhotoModeInstant.PhotoModeInstantPCView m_PhotoModeInstantPCView /* Kingmaker.UI.MVVM._PCView.PhotoModeInstant.PhotoModeInstantPCView */;
    [SerializeField] public global::Kingmaker.UI.WarningsText m_WarningsText /* Kingmaker.UI.WarningsText */;
}

}

