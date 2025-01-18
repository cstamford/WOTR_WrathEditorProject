using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class TwistRelaxer : MonoBehaviour {
    public object ik /* RootMotion.FinalIK.IK */;
    public Transform parent /* UnityEngine.Transform */;
    public Transform child /* UnityEngine.Transform */;
    public float weight /* System.Single */;
    public float parentChildCrossfade /* System.Single */;
    public float twistAngleOffset /* System.Single */;
}

}

