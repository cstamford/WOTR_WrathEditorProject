using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.LocalMap;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Menu;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows {

public class ServiceWindowsPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Menu.ServiceWindowMenuPCView m_ServiceWindowMenuPcView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Menu.ServiceWindowMenuPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryPCView m_InventoryPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.CharacterInfoPCView m_CharacterInfoPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.CharacterInfoPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoPCView MythicInfoPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.SpellbookPCView m_SpellbookPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Spellbook.SpellbookPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalPCView m_JournalPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal.JournalPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.EncyclopediaPCView m_EncyclopediaPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.EncyclopediaPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.LocalMap.LocalMapPCView m_LocalMapPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.LocalMap.LocalMapPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Background /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

