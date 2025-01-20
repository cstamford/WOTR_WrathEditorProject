using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class LookAtController : global::UnityEngine.MonoBehaviour {
    public global::RootMotion.FinalIK.LookAtIK ik /* RootMotion.FinalIK.LookAtIK */;
    public global::UnityEngine.Transform target /* UnityEngine.Transform */;
    public float weight /* System.Single */;
    public global::UnityEngine.Vector3 offset /* UnityEngine.Vector3 */;
    public float targetSwitchSmoothTime /* System.Single */;
    public float weightSmoothTime /* System.Single */;
    public bool smoothTurnTowardsTarget /* System.Boolean */;
    public float maxRadiansDelta /* System.Single */;
    public float maxMagnitudeDelta /* System.Single */;
    public float slerpSpeed /* System.Single */;
    public global::UnityEngine.Vector3 pivotOffsetFromRoot /* UnityEngine.Vector3 */;
    public float minDistance /* System.Single */;
    public float maxRootAngle /* System.Single */;
}

}

