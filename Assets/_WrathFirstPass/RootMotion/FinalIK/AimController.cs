using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class AimController : MonoBehaviour {
    public object ik /* RootMotion.FinalIK.AimIK */;
    public float weight /* System.Single */;
    public Transform target /* UnityEngine.Transform */;
    public float targetSwitchSmoothTime /* System.Single */;
    public float weightSmoothTime /* System.Single */;
    public bool smoothTurnTowardsTarget /* System.Boolean */;
    public float maxRadiansDelta /* System.Single */;
    public float maxMagnitudeDelta /* System.Single */;
    public float slerpSpeed /* System.Single */;
    public Vector3 pivotOffsetFromRoot /* UnityEngine.Vector3 */;
    public float minDistance /* System.Single */;
    public Vector3 offset /* UnityEngine.Vector3 */;
    public float maxRootAngle /* System.Single */;
    public bool turnToTarget /* System.Boolean */;
    public float turnToTargetTime /* System.Single */;
    public bool useAnimatedAimDirection /* System.Boolean */;
    public Vector3 animatedAimDirection /* UnityEngine.Vector3 */;
}

}

