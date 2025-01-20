using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Attack;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory {

public class InventoryConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView m_NameAndPortraitPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.CharInfoLevelClassScoresConsoleView m_LevelClassScoresView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.LevelClassScores.CharInfoLevelClassScoresConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_CharInfoContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockConsoleView m_AttacksBlockView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Attack.CharInfoAttacksBlockConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockConsoleView m_DefenceBlockView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.Martial.Defence.CharInfoDefenceBlockConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_MartialContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryDollConsoleView m_InventoryDollView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryDollConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryStashConsoleView m_InventoryStashView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryStashConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventorySmartItemConsoleView m_InventorySmartItemView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventorySmartItemConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_LeftInfoPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_RightInfoPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryEquipSelectorConsoleView m_EquipSelectorConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryEquipSelectorConsoleView */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public float m_RotateFactor /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
}

}

