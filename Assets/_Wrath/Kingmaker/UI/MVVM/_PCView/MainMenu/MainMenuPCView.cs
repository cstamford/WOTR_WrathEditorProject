using Kingmaker.UI;
using Kingmaker.UI.MVVM._PCView.CharGen;
using Kingmaker.UI.MVVM._PCView.Common.MessageModal;
using Kingmaker.UI.MVVM._PCView.NewGame;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.MainMenu {

public class MainMenuPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.MainMenu.MainMenuSideBarPCView m_MainMenuSideBarPCView /* Kingmaker.UI.MVVM._PCView.MainMenu.MainMenuSideBarPCView */;
    [SerializeField] public global::Kingmaker.UI.TermsOfUseController m_TermOfUse /* Kingmaker.UI.TermsOfUseController */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.CharGenContextPCView m_CharGenContextPCView /* Kingmaker.UI.MVVM._PCView.CharGen.CharGenContextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.NewGame.NewGamePCView NewGamePCView /* Kingmaker.UI.MVVM._PCView.NewGame.NewGamePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Common.MessageModal.MarketingMessagePCView m_MarketingMessageView /* Kingmaker.UI.MVVM._PCView.Common.MessageModal.MarketingMessagePCView */;
}

}

