using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Portrait {

public class CharGenCustomPortraitCreatorConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_DescriptionLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitHalf /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitSmall /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public object m_OpenFolderButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_OpenFolderLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RefreshPortraitButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_RefreshPortraitLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

