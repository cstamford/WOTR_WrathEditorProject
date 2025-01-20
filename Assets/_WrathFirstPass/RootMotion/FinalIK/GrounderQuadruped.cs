using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class GrounderQuadruped {
    public object forelegSolver /* RootMotion.FinalIK.Grounding */;
    public float rootRotationWeight /* System.Single */;
    public float minRootRotation /* System.Single */;
    public float maxRootRotation /* System.Single */;
    public float rootRotationSpeed /* System.Single */;
    public float maxLegOffset /* System.Single */;
    public float maxForeLegOffset /* System.Single */;
    public float maintainHeadRotationWeight /* System.Single */;
    public global::UnityEngine.Transform characterRoot /* UnityEngine.Transform */;
    public global::UnityEngine.Transform pelvis /* UnityEngine.Transform */;
    public global::UnityEngine.Transform lastSpineBone /* UnityEngine.Transform */;
    public global::UnityEngine.Transform head /* UnityEngine.Transform */;
    public object legs /* RootMotion.FinalIK.IK[] */;
    public object forelegs /* RootMotion.FinalIK.IK[] */;
    public global::UnityEngine.Vector3 gravity /* UnityEngine.Vector3 */;
}

}

