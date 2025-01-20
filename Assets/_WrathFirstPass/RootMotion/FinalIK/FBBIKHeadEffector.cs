using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class FBBIKHeadEffector : global::UnityEngine.MonoBehaviour {
    public global::RootMotion.FinalIK.FullBodyBipedIK ik /* RootMotion.FinalIK.FullBodyBipedIK */;
    public float positionWeight /* System.Single */;
    public float bodyWeight /* System.Single */;
    public float thighWeight /* System.Single */;
    public bool handsPullBody /* System.Boolean */;
    public float rotationWeight /* System.Single */;
    public float bodyClampWeight /* System.Single */;
    public float headClampWeight /* System.Single */;
    public float bendWeight /* System.Single */;
    public object bendBones /* RootMotion.FinalIK.BendBone[] */;
    public float CCDWeight /* System.Single */;
    public float roll /* System.Single */;
    public float damper /* System.Single */;
    public global::UnityEngine.Transform[] CCDBones /* UnityEngine.Transform[] */;
    public float postStretchWeight /* System.Single */;
    public float maxStretch /* System.Single */;
    public float stretchDamper /* System.Single */;
    public bool fixHead /* System.Boolean */;
    public global::UnityEngine.Transform[] stretchBones /* UnityEngine.Transform[] */;
    public global::UnityEngine.Vector3 chestDirection /* UnityEngine.Vector3 */;
    public float chestDirectionWeight /* System.Single */;
    public global::UnityEngine.Transform[] chestBones /* UnityEngine.Transform[] */;

    public class BendBone {
        public global::UnityEngine.Transform transform /* UnityEngine.Transform */;
        public float weight /* System.Single */;
    }

}

}

