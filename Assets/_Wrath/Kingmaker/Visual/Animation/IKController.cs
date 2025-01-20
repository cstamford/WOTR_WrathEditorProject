using Kingmaker.UI.ServiceWindow;
using Kingmaker.View;
using Kingmaker.Visual.CharacterSystem;
using RootMotion.FinalIK;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class IKController {
    public global::RootMotion.FinalIK.LimbIK LeftArmLimbIk /* RootMotion.FinalIK.LimbIK */;
    public global::RootMotion.FinalIK.LimbIK RightArmLimbIk /* RootMotion.FinalIK.LimbIK */;
    public global::RootMotion.FinalIK.GrounderBipedIK GrounderIK /* RootMotion.FinalIK.GrounderBipedIK */;
    public global::Kingmaker.Visual.CharacterSystem.Character CharacterSystem /* Kingmaker.Visual.CharacterSystem.Character */;
    public global::Kingmaker.View.UnitEntityView CharacterUnitEntity /* Kingmaker.View.UnitEntityView */;
    public global::Kingmaker.UI.ServiceWindow.DollRoom DollRoom /* Kingmaker.UI.ServiceWindow.DollRoom */;
    public global::Kingmaker.Visual.Animation.IKControllerSettings Settings /* Kingmaker.Visual.Animation.IKControllerSettings */;
}

}

