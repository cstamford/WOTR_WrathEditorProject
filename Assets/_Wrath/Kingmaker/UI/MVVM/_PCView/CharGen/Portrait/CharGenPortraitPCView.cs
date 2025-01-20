using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.LevelUp;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Portrait {

public class CharGenPortraitPCView {
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger m_Portrait /* Kingmaker.UI.LevelUp.CharBPortraitChanger */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Portrait.CharGenPortraitPCView.PortraitSize m_Size /* Kingmaker.UI.MVVM._PCView.CharGen.Portrait.PortraitSize */;

    public enum PortraitSize {
        Small = 0,
        Middle = 1,
        Full = 2,
    }

}

}

