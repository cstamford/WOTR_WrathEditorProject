using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo {

public class MythicInfoPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView NameAndPortraitPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.CharacterInfo.Sections.NameAndPortrait.CharInfoNameAndPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoLevelPCView m_LevelView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoLevelPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoLevelPCView m_LevelViewOnNoMythicScreen /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoLevelPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoSpellTablePCView m_SpellTableView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoSpellTablePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionPCView ProgressionPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionView DLC5ProgressionPCView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionView */;
    [SerializeField] public global::UnityEngine.UI.Image m_Emblem /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_NoMythicContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_NoMythicLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_mythicVisualVariantView /* Kingmaker.UI.MVVM._VM.DLC5.MythicVisualVariantView[] */;
}

}

