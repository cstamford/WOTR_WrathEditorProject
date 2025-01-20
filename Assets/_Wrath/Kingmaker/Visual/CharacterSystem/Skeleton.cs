using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class Skeleton : global::UnityEngine.ScriptableObject {
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Skeleton.Bone> Bones /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Bone> */;
    public global::Kingmaker.Visual.CharacterSystem.CharacterFxBonesMap CharacterFxBonesMap /* Kingmaker.Visual.CharacterSystem.CharacterFxBonesMap */;
    public float CloakScaleFudge /* System.Single */;
    public global::UnityEngine.GameObject RagdollSkeletonOverride /* UnityEngine.GameObject */;
    [SerializeField] public object m_DollRoomZoomPreset /* Kingmaker.UI.ServiceWindow.DollRoomCameraZoomPreset */;

    public class Bone {
        public string Name /* System.String */;
        public global::UnityEngine.Vector3 Scale /* UnityEngine.Vector3 */;
        public global::UnityEngine.Vector3 Offset /* UnityEngine.Vector3 */;
        public bool ApplyOffset /* System.Boolean */;
    }

}

}

