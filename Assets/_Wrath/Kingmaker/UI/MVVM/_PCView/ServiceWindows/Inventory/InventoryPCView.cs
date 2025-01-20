using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory {

public class InventoryPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView NameAndPortraitPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.CharInfoLevelClassScoresPCView m_LevelClassScoresView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.CharInfoLevelClassScoresPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockPCView m_AttacksBlockView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockPCView m_DefenceBlockView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryDollPCView m_DollView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryDollPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryStashPCView m_StashView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventoryStashPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_StashContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventorySmartItemPCView m_SmartItemView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.InventorySmartItemPCView */;
    [SerializeField] public object m_SmartItemButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_SmartItemButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SharedStashButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_SmartItemButtonContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_SmartItemImage /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_SharedStashImage /* UnityEngine.GameObject */;
}

}

