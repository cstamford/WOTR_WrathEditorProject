using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class Skeleton : ScriptableObject {
    public List<Skeleton.Bone> Bones /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Bone> */;
    public CharacterFxBonesMap CharacterFxBonesMap /* Kingmaker.Visual.CharacterSystem.CharacterFxBonesMap */;
    public float CloakScaleFudge /* System.Single */;
    public GameObject RagdollSkeletonOverride /* UnityEngine.GameObject */;
    [SerializeField] public object m_DollRoomZoomPreset /* Kingmaker.UI.ServiceWindow.DollRoomCameraZoomPreset */;

    public class Bone {
        public string Name /* System.String */;
        public Vector3 Scale /* UnityEngine.Vector3 */;
        public Vector3 Offset /* UnityEngine.Vector3 */;
        public bool ApplyOffset /* System.Boolean */;
    }

}

}

