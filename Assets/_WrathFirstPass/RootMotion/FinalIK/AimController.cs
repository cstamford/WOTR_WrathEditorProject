using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class AimController : global::UnityEngine.MonoBehaviour {
    public global::RootMotion.FinalIK.AimIK ik /* RootMotion.FinalIK.AimIK */;
    public float weight /* System.Single */;
    public global::UnityEngine.Transform target /* UnityEngine.Transform */;
    public float targetSwitchSmoothTime /* System.Single */;
    public float weightSmoothTime /* System.Single */;
    public bool smoothTurnTowardsTarget /* System.Boolean */;
    public float maxRadiansDelta /* System.Single */;
    public float maxMagnitudeDelta /* System.Single */;
    public float slerpSpeed /* System.Single */;
    public global::UnityEngine.Vector3 pivotOffsetFromRoot /* UnityEngine.Vector3 */;
    public float minDistance /* System.Single */;
    public global::UnityEngine.Vector3 offset /* UnityEngine.Vector3 */;
    public float maxRootAngle /* System.Single */;
    public bool turnToTarget /* System.Boolean */;
    public float turnToTargetTime /* System.Single */;
    public bool useAnimatedAimDirection /* System.Boolean */;
    public global::UnityEngine.Vector3 animatedAimDirection /* UnityEngine.Vector3 */;
}

}

