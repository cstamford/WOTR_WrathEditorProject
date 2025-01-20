using System;
using UnityEngine;

namespace Kingmaker {

public class NahindriIK : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object IKBoneStructure /* Kingmaker.BoneStructure[] */;
    [SerializeField] public global::UnityEngine.Vector3 AngleOffset /* UnityEngine.Vector3 */;
    [SerializeField] public global::UnityEngine.Vector3 ProjectionOffset /* UnityEngine.Vector3 */;
    [SerializeField] public float Weight /* System.Single */;
    [SerializeField] public float WeightStep /* System.Single */;
    [SerializeField] public bool ShowDebugGizmos /* System.Boolean */;

    public struct BoneStructure {
        [SerializeField] public global::UnityEngine.Transform bone /* UnityEngine.Transform */;
        [SerializeField] public bool isRootLevelBone /* System.Boolean */;
    }

}

}

