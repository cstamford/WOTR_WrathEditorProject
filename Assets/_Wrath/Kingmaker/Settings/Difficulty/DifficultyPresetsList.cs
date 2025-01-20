using System;
using UnityEngine;

namespace Kingmaker.Settings.Difficulty {

public class DifficultyPresetsList : global::UnityEngine.ScriptableObject {
    [SerializeField] public object m_Difficulties /* Kingmaker.Settings.Difficulty.DifficultyPresetAsset[] */;
    [SerializeField] public global::Kingmaker.Settings.Difficulty.DifficultyPresetAsset m_CoreDifficulty /* Kingmaker.Settings.Difficulty.DifficultyPresetAsset */;
    [SerializeField] public global::Kingmaker.Settings.Difficulty.DifficultyPresetAsset m_HardDifficulty /* Kingmaker.Settings.Difficulty.DifficultyPresetAsset */;
    [SerializeField] public global::Kingmaker.Settings.Difficulty.DifficultyPresetAsset m_UnfairDifficulty /* Kingmaker.Settings.Difficulty.DifficultyPresetAsset */;
    public object StatsAdjustmentPresets /* Kingmaker.Settings.Difficulty.StatsAdjustmentPreset[] */;
    public float[] MobExperienceCoeffs /* System.Single[] */;

    public class StatsAdjustmentPreset {
        public object Preset /* Kingmaker.Settings.StatsAdjustmentsType */;
        public int BasicStatBonusMultiplier /* System.Int32 */;
        public float BasicStatCoefficientStart /* System.Single */;
        public float BasicStatCoefficientEnd /* System.Single */;
        public int BasicStatCoefficientCRCap /* System.Int32 */;
        public int DerivativeStatBonusMultiplier /* System.Int32 */;
        public float DerivativeStatCoefficientStart /* System.Single */;
        public float DerivativeStatCoefficientEnd /* System.Single */;
        public int DerivativeStatCoefficientCRCap /* System.Int32 */;
        public float HPMultiplier /* System.Single */;
        public int ACBonusMultiplier /* System.Int32 */;
        public int AbilityDCBonus /* System.Int32 */;
        public int AbilityDCLimit /* System.Int32 */;
        public int AbilityDCLimitCoeff /* System.Int32 */;
        public int SkillCheckDCBonus /* System.Int32 */;
    }

}

}

