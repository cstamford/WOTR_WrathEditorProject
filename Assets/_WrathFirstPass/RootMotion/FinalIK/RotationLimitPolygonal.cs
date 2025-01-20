using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class RotationLimitPolygonal {
    public float twistLimit /* System.Single */;
    public int smoothIterations /* System.Int32 */;
    [SerializeField] public object points /* RootMotion.FinalIK.LimitPoint[] */;
    [SerializeField] public global::UnityEngine.Vector3[] P /* UnityEngine.Vector3[] */;
    [SerializeField] public object reachCones /* RootMotion.FinalIK.ReachCone[] */;

    public class ReachCone {
        public global::UnityEngine.Vector3[] tetrahedron /* UnityEngine.Vector3[] */;
        public float volume /* System.Single */;
        public global::UnityEngine.Vector3 S /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 B /* UnityEngine.Vector3 */;
    }

    public class LimitPoint {
        public global::UnityEngine.Vector3 point /* UnityEngine.Vector3 */;
        public float tangentWeight /* System.Single */;
    }

}

}

