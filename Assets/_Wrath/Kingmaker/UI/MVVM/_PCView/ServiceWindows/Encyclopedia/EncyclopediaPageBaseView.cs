using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia {

public class EncyclopediaPageBaseView {
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidjetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator ContentAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockTextPCView m_TextBlockPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockTextPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockImagePCView m_ImageBlockPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockImagePCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockUnitPCView m_UnitBlockPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockUnitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockClassProgressionPCView m_ClassProgressionBlockPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockClassProgressionPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockChildPagesPCView m_ChildPagesPrefab /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Encyclopedia.Blocks.EncyclopediaPageBlockChildPagesPCView */;
    [SerializeField] public object m_PreviousButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

