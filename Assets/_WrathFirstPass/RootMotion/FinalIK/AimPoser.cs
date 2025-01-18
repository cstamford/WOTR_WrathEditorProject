using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class AimPoser : MonoBehaviour {
    public float angleBuffer /* System.Single */;
    public object poses /* RootMotion.FinalIK.Pose[] */;

    public class Pose {
        public bool visualize /* System.Boolean */;
        public string name /* System.String */;
        public Vector3 direction /* UnityEngine.Vector3 */;
        public float yaw /* System.Single */;
        public float pitch /* System.Single */;
    }

}

}

