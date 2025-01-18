using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class FBBIKHeadEffector : MonoBehaviour {
    public object ik /* RootMotion.FinalIK.FullBodyBipedIK */;
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
    public Transform[] CCDBones /* UnityEngine.Transform[] */;
    public float postStretchWeight /* System.Single */;
    public float maxStretch /* System.Single */;
    public float stretchDamper /* System.Single */;
    public bool fixHead /* System.Boolean */;
    public Transform[] stretchBones /* UnityEngine.Transform[] */;
    public Vector3 chestDirection /* UnityEngine.Vector3 */;
    public float chestDirectionWeight /* System.Single */;
    public Transform[] chestBones /* UnityEngine.Transform[] */;

    public class BendBone {
        public Transform transform /* UnityEngine.Transform */;
        public float weight /* System.Single */;
    }

}

}

