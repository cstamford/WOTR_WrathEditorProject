using Kingmaker.Utility;
using Kingmaker.Visual.Animation;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class Character {
    public global::System.Nullable<bool> PreventUpdate /* System.Nullable<System.Boolean> */;
    [SerializeField] public global::Kingmaker.Visual.CharacterSystem.Skeleton m_Skeleton /* Kingmaker.Visual.CharacterSystem.Skeleton */;
    [SerializeField] public bool m_Mirror /* System.Boolean */;
    public global::Kingmaker.Visual.Animation.AnimationSet m_AnimationSet /* Kingmaker.Visual.Animation.AnimationSet */;
    public global::UnityEngine.Animator AnimatorPrefab /* UnityEngine.Animator */;
    public bool IsDirty /* System.Boolean */;
    public bool IsAtlasesDirty /* System.Boolean */;
    public bool IsInDollRoom /* System.Boolean */;
    public bool SaveRagdoll /* System.Boolean */;
    public global::Kingmaker.Visual.CharacterSystem.Character.AtlasSize MaxAtlasSize /* Kingmaker.Visual.CharacterSystem.AtlasSize */;
    public global::Kingmaker.Visual.CharacterSystem.BakedCharacter BakedCharacter /* Kingmaker.Visual.CharacterSystem.BakedCharacter */;
    [SerializeField] public global::Kingmaker.Visual.CharacterSystem.CharacterBonesList m_BonesList /* Kingmaker.Visual.CharacterSystem.CharacterBonesList */;
    [SerializeField] public object m_SavedEquipmentEntities /* System.Collections.Generic.List */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Character.SavedSelectedRampIndices> m_SavedRampIndices /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.SavedSelectedRampIndices> */;
    public bool canNotBeRebaked /* System.Boolean */;
    [SerializeField] public global::Kingmaker.Visual.CharacterSystem.CharacterStudio.Gender m_Gender /* Kingmaker.Visual.CharacterSystem.Gender */;
    [SerializeField] public global::Kingmaker.Visual.CharacterSystem.CharacterStudio.Race m_Race /* Kingmaker.Visual.CharacterSystem.Race */;
    public global::Kingmaker.Utility.SwitchPrefabs CloakSwitcher /* Kingmaker.Utility.SwitchPrefabs */;

    public enum AtlasSize {
        AtlasSize512 = 512,
        AtlasSize1024 = 1024,
        AtlasSize2048 = 2048,
    }

    public class SavedSelectedRampIndices {
        public object EquipmentEntityLink /* Kingmaker.ResourceLinks.EquipmentEntityLink */;
        public int PrimaryIndex /* System.Int32 */;
        public int SecondaryIndex /* System.Int32 */;
    }

}

}

