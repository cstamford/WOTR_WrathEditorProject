using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic;
using Kingmaker.UI.MVVM._PCView.CharGen.Portrait;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class CharGenView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.CharGenRoadmapMenuView RoadmapMenuView /* Kingmaker.UI.MVVM._PCView.CharGen.CharGenRoadmapMenuView */;
    [SerializeField] public object m_LevelUpLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_UpToLevel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject LevelNumContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.CharGenProgressionView m_CharGenProgressionView /* Kingmaker.UI.MVVM._PCView.CharGen.CharGenProgressionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic.CharGenMythicProgressionView m_CharGenMythicProgressionView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic.CharGenMythicProgressionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_InfoView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView m_PortraitView /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_DollRoom /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_MythicDollRoom /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
}

}

