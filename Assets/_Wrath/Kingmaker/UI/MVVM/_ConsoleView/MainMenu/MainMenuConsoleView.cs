using Kingmaker.UI;
using Kingmaker.UI.MVVM._ConsoleView.CharGen;
using Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal;
using Kingmaker.UI.MVVM._ConsoleView.DLCManager;
using Kingmaker.UI.MVVM._ConsoleView.NewGame;
using Kingmaker.UI.MVVM._PCView.MainMenu;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.MainMenu {

public class MainMenuConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.MainMenu.MainMenuSideBarConsoleView m_MenuSideBarConsoleView /* Kingmaker.UI.MVVM._ConsoleView.MainMenu.MainMenuSideBarConsoleView */;
    [SerializeField] public global::Kingmaker.UI.TermsOfUseConsoleController m_TermOfUse /* Kingmaker.UI.TermsOfUseConsoleController */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenContextConsoleView m_CharGenContextConsoleView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.CharGenContextConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.NewGame.NewGameConsoleView m_NewGameConsoleView /* Kingmaker.UI.MVVM._ConsoleView.NewGame.NewGameConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.DLCManager.DLCManagerConsoleView m_DLCManagerConsoleView /* Kingmaker.UI.MVVM._ConsoleView.DLCManager.DLCManagerConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal.MarketingMessageConsoleView m_MarketingMessageView /* Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal.MarketingMessageConsoleView */;
}

}

