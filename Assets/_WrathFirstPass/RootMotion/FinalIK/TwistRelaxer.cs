using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class TwistRelaxer : global::UnityEngine.MonoBehaviour {
    public global::RootMotion.FinalIK.IK ik /* RootMotion.FinalIK.IK */;
    public global::UnityEngine.Transform parent /* UnityEngine.Transform */;
    public global::UnityEngine.Transform child /* UnityEngine.Transform */;
    public float weight /* System.Single */;
    public float parentChildCrossfade /* System.Single */;
    public float twistAngleOffset /* System.Single */;
}

}

