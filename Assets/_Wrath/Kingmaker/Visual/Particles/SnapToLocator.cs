using RootMotion.FinalIK;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class SnapToLocator {
    public string BoneName /* System.String */;
    public global::UnityEngine.AnimationCurve CameraOffsetScale /* UnityEngine.AnimationCurve */;
    public bool DontScale /* System.Boolean */;
    public bool DontRotate /* System.Boolean */;
    public bool DontAttach /* System.Boolean */;
    public bool DropToGround /* System.Boolean */;
    public global::System.Collections.Generic.List<string> BoneNames /* System.Collections.Generic.List<System.String> */;
    [SerializeField] public global::RootMotion.FinalIK.FullBodyBipedIK m_FullBodyBipedIK /* RootMotion.FinalIK.FullBodyBipedIK */;
}

}

