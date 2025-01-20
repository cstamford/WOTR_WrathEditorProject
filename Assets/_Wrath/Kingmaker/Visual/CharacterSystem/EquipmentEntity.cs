using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class EquipmentEntity : global::UnityEngine.ScriptableObject {
    public bool IsExportEnabled /* System.Boolean */;
    public bool CantBeHiddenByDollRoom /* System.Boolean */;
    public int Layer /* System.Int32 */;
    [SerializeField] public long m_HideBodyParts /* System.Int64 */;
    public bool ShowLowerMaterials /* System.Boolean */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Skeleton.Bone> SkeletonModifiers /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Bone> */;
    public global::Kingmaker.Visual.CharacterSystem.CharacterColorsProfile PrimaryColorsProfile /* Kingmaker.Visual.CharacterSystem.CharacterColorsProfile */;
    public global::Kingmaker.Visual.CharacterSystem.CharacterColorsProfile SecondaryColorsProfile /* Kingmaker.Visual.CharacterSystem.CharacterColorsProfile */;
    public bool PrimaryColorsAvailableForPlayer /* System.Boolean */;
    public bool SecondaryColorsAvailableForPlayer /* System.Boolean */;
    public global::Kingmaker.Visual.CharacterSystem.CharacterBakedTextures BakedTextures /* Kingmaker.Visual.CharacterSystem.CharacterBakedTextures */;
    [SerializeField] public global::Kingmaker.Visual.CharacterSystem.RampColorPreset ColorPresets /* Kingmaker.Visual.CharacterSystem.RampColorPreset */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Texture2D> m_PrimaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Texture2D> m_SecondaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Texture2D> m_SpecialPrimaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Texture2D> m_SpecialSecondaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    public object BodyParts /* System.Collections.Generic.List */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.EquipmentEntity.OutfitPart> OutfitParts /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.OutfitPart> */;
    [SerializeField] public object m_DlcReward /* Kingmaker.Blueprints.BlueprintDlcRewardReference */;
    public bool IsLowresVariant /* System.Boolean */;
    public string OtherVariantGuid /* System.String */;

    public interface IColorRampIndicesProvider {
    }

    public enum OutfitPartSpecialType {
        None = 0,
        Backpack = 1,
        LoadRuntimeHasBakedTexture = 4,
        LoadRuntime = 5,
    }

    public class OutfitPart {
        [SerializeField] public global::UnityEngine.GameObject m_Prefab /* UnityEngine.GameObject */;
        [SerializeField] public global::UnityEngine.Material m_Material /* UnityEngine.Material */;
        public global::UnityEngine.Material tempMaterial /* UnityEngine.Material */;
        [SerializeField] public global::UnityEngine.Vector3 m_Position /* UnityEngine.Vector3 */;
        [SerializeField] public global::UnityEngine.Vector3 m_Rotation /* UnityEngine.Vector3 */;
        [SerializeField] public global::UnityEngine.Vector3 m_Scale /* UnityEngine.Vector3 */;
        public int PrimaryIndex /* System.Int32 */;
        public int SecondaryIndex /* System.Int32 */;
        public global::UnityEngine.Texture2D DiffuseTexture /* UnityEngine.Texture2D */;
        public global::UnityEngine.Texture2D FirstCapeColorMask /* UnityEngine.Texture2D */;
        public global::UnityEngine.Texture2D SecondCapeColorMask /* UnityEngine.Texture2D */;
        [SerializeField] public string m_BoneName /* System.String */;
        [SerializeField] public bool m_StaysInPeacefulMode /* System.Boolean */;
        [SerializeField] public bool m_OnlyInDollRoom /* System.Boolean */;
        [SerializeField] public global::Kingmaker.Visual.CharacterSystem.EquipmentEntity.OutfitPartSpecialType m_Special /* Kingmaker.Visual.CharacterSystem.OutfitPartSpecialType */;
        [SerializeField] public long OutfitBodyPart /* System.Int64 */;
    }

}

}

