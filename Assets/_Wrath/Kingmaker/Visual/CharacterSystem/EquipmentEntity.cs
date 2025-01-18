using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class EquipmentEntity : ScriptableObject {
    public bool IsExportEnabled /* System.Boolean */;
    public bool CantBeHiddenByDollRoom /* System.Boolean */;
    public int Layer /* System.Int32 */;
    [SerializeField] public long m_HideBodyParts /* System.Int64 */;
    public bool ShowLowerMaterials /* System.Boolean */;
    public List<Skeleton.Bone> SkeletonModifiers /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Bone> */;
    public CharacterColorsProfile PrimaryColorsProfile /* Kingmaker.Visual.CharacterSystem.CharacterColorsProfile */;
    public CharacterColorsProfile SecondaryColorsProfile /* Kingmaker.Visual.CharacterSystem.CharacterColorsProfile */;
    public bool PrimaryColorsAvailableForPlayer /* System.Boolean */;
    public bool SecondaryColorsAvailableForPlayer /* System.Boolean */;
    public CharacterBakedTextures BakedTextures /* Kingmaker.Visual.CharacterSystem.CharacterBakedTextures */;
    [SerializeField] public RampColorPreset ColorPresets /* Kingmaker.Visual.CharacterSystem.RampColorPreset */;
    [SerializeField] public List<Texture2D> m_PrimaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public List<Texture2D> m_SecondaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public List<Texture2D> m_SpecialPrimaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public List<Texture2D> m_SpecialSecondaryRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    public object BodyParts /* System.Collections.Generic.List */;
    public List<EquipmentEntity.OutfitPart> OutfitParts /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.OutfitPart> */;
    [SerializeField] public object m_DlcReward /* Kingmaker.Blueprints.BlueprintDlcRewardReference */;
    public bool IsLowresVariant /* System.Boolean */;
    public string OtherVariantGuid /* System.String */;

    public enum OutfitPartSpecialType {
        None = 0,
        Backpack = 1,
        LoadRuntimeHasBakedTexture = 4,
        LoadRuntime = 5,
    }

    public class OutfitPart {
        [SerializeField] public GameObject m_Prefab /* UnityEngine.GameObject */;
        [SerializeField] public Material m_Material /* UnityEngine.Material */;
        public Material tempMaterial /* UnityEngine.Material */;
        [SerializeField] public Vector3 m_Position /* UnityEngine.Vector3 */;
        [SerializeField] public Vector3 m_Rotation /* UnityEngine.Vector3 */;
        [SerializeField] public Vector3 m_Scale /* UnityEngine.Vector3 */;
        public int PrimaryIndex /* System.Int32 */;
        public int SecondaryIndex /* System.Int32 */;
        public Texture2D DiffuseTexture /* UnityEngine.Texture2D */;
        public Texture2D FirstCapeColorMask /* UnityEngine.Texture2D */;
        public Texture2D SecondCapeColorMask /* UnityEngine.Texture2D */;
        [SerializeField] public string m_BoneName /* System.String */;
        [SerializeField] public bool m_StaysInPeacefulMode /* System.Boolean */;
        [SerializeField] public bool m_OnlyInDollRoom /* System.Boolean */;
        [SerializeField] public EquipmentEntity.OutfitPartSpecialType m_Special /* Kingmaker.Visual.CharacterSystem.OutfitPartSpecialType */;
        [SerializeField] public long OutfitBodyPart /* System.Int64 */;
    }

}

}

