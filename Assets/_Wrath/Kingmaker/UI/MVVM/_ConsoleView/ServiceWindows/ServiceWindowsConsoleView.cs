using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Journal;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.LocalMap;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows {

public class ServiceWindowsConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryConsoleView m_InventoryConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.CharacterInfoConsoleView m_CharacterInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.CharacterInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookConsoleView m_SpellbookConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.SpellbookConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoConsoleView m_MythicInfoConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Journal.JournalConsoleView m_JournalConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Journal.JournalConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia.EncyclopediaConsoleView m_EncyclopediaConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Encyclopedia.EncyclopediaConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.LocalMap.LocalMapConsoleView m_LocalMapConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.LocalMap.LocalMapConsoleView */;
}

}

