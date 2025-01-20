using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.CharGen;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic {

public class CharGenMythicProgressionView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionView m_MythicProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionView m_DLC5MythicProgressionView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.MythicInfo.MythicInfoProgressionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.EdgeWindowView m_EdgeWindowView /* Kingmaker.UI.MVVM._PCView.CharGen.EdgeWindowView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

