using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo {

public class MythicInfoConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitConsoleView NameAndPortraitConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitConsoleView DLC5NameAndPortraitConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainFadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoLevelConsoleView m_LevelView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoLevelConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoLevelConsoleView m_DLC5LevelView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoLevelConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoLevelPCView m_LevelViewOnNoMythicScreen /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoLevelPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoSpellTableConsoleView m_SpellTableView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoSpellTableConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoProgressionConsoleView m_ProgressionView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoProgressionConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoProgressionConsoleView m_DLC5ProgressionView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.MythicInfo.MythicInfoProgressionConsoleView */;
    [SerializeField] public global::UnityEngine.UI.Image m_Emblem /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_NoMythicContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_NoMythicLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_Parameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public object m_MythicVisualVariantView /* Kingmaker.UI.MVVM._VM.DLC5.MythicVisualVariantView[] */;
}

}

