using System;
using UnityEngine;

namespace Kingmaker.Visual.Mounts {

public class RaceMountOffsetsConfig : global::UnityEngine.ScriptableObject {
    [SerializeField] public object offsets /* Kingmaker.Visual.Mounts.MountOffsetData[] */;

    public class MountOffsetData {
        public object Races /* System.Collections.Generic.List */;
        public global::UnityEngine.Vector3 RootPosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 RootBattlePosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 SaddleRootPosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 SaddleRootScale /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector4 SaddleRootRotation /* UnityEngine.Vector4 */;
        public global::UnityEngine.Vector3 PelvisPosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector4 PelvisRotation /* UnityEngine.Vector4 */;
        public global::UnityEngine.Vector3 LeftFootPosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector4 LeftFootRotation /* UnityEngine.Vector4 */;
        public global::UnityEngine.Vector3 LeftKneePosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 RightFootPosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector4 RightFootRotation /* UnityEngine.Vector4 */;
        public global::UnityEngine.Vector3 RightKneePosition /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 HandsPosition /* UnityEngine.Vector3 */;
        public float PelvisPositionWeight /* System.Single */;
        public float PelvisRotationWeight /* System.Single */;
        public float FootsPositionWeight /* System.Single */;
        public float FootsRotationWeight /* System.Single */;
        public float KneesBendWeight /* System.Single */;
        public float HandsPositionWeight /* System.Single */;
        public float HandsMappingWeight /* System.Single */;
    }

}

}

