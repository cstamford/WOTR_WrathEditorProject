using Kingmaker.UI.MVVM._PCView.Tooltip.Bricks;
using Kingmaker.UI.MVVM._VM.Tooltip.Bricks;
using Kingmaker.UI.MVVM._VM.Tooltip.Templates;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Tooltip {

public class TooltipBricksView : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTextView BrickTextView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTextView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSeparatorView BrickSeparatorView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSeparatorView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSpaceView BrickSpaceView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSpaceView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTitleView BrickTitleView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTitleView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickPictureView BrickPictureView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickPictureView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIconAndNameView BrickIconAndNameView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIconAndNameView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIconNameDescView BrickIconNameDescView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIconNameDescView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickDoubleTextView BrickDoubleTextView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickDoubleTextView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTripleTextView BrickTripleTextView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTripleTextView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIconValueStatView BrickIconValueStatView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIconValueStatView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickThreeColumnsStatView BrickThreeColumnsStatView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickThreeColumnsStatView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTwoColumnsStatView BrickTwoColumnsStatView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTwoColumnsStatView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickValueStatFormulaView BrickValueStatFormulaView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickValueStatFormulaView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTimerView BrickTimerView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickTimerView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickEntityHeaderView BrickEntityHeaderView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickEntityHeaderView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSavingThrowView BrickSavingThrowView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSavingThrowView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickBabHorizontalView BrickBabHorizontalView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickBabHorizontalView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickBabVerticalView BrickBabVerticalView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickBabVerticalView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSpellTableView BrickSpellTableView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSpellTableView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickFeatureView BrickFeatureView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickFeatureView */;
    public global::Kingmaker.UI.MVVM._VM.Tooltip.Templates.TooltipBrickFeatureHeaderView BrickFeatureHeaderView /* Kingmaker.UI.MVVM._VM.Tooltip.Templates.TooltipBrickFeatureHeaderView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickBuffView BrickBuffView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickBuffView */;
    public global::Kingmaker.UI.MVVM._VM.Tooltip.Bricks.TooltipBrickColorizedTextView BrickColorizedTextView /* Kingmaker.UI.MVVM._VM.Tooltip.Bricks.TooltipBrickColorizedTextView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArchetypeFeatureView BrickArchetypeFeatureView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArchetypeFeatureView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickItemFooterView BrickItemFooterView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickItemFooterView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityScoresView BrickAbilityScoresView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityScoresView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArmorClassView BrickArmorClassView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArmorClassView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSizeSpeedInitiativeView BrickSizeSpeedInitiativeView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSizeSpeedInitiativeView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSizeSpeedInitiativeView BricksSizeSpeedInitiativeTacticalCombatView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSizeSpeedInitiativeView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleIconValueStatView BrickMultipleIconValueStatView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleIconValueStatView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleBuffView BrickMultipleBuffView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleBuffView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleFeatureView BrickMultipleFeatureView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleFeatureView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleValueStatFormulaView BrickMultipleValueStatFormulaView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickMultipleValueStatFormulaView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickEncumbranceView BrickEncumbranceView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickEncumbranceView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickPortraitAndNameView BrickPortraitAndNameView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickPortraitAndNameView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickButtonView BrickButtonView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickButtonView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickHistoryManagementView BrickHistoryManagementView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickHistoryManagementView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickNonStackView BrickNonStackView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickNonStackView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickChangeVisualView BrickChangeVisualView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickChangeVisualView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickPrerequisiteView BrickPrerequisiteView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickPrerequisiteView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickRateView BrickRateView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickRateView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAutoLevelupButtonView BrickAutoLevelupButtonView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAutoLevelupButtonView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickClassBalanceView BrickClassBalanceView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickClassBalanceView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickShortClassDescriptionView BrickShortClassDescriptionView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickShortClassDescriptionView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickFeatureShortDescriptionView BrickFeatureShortDescriptionView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickFeatureShortDescriptionView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityScoresBlockView BrickAbilityScoresBlockView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityScoresBlockView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSkillsView BrickSkillsView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickSkillsView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityTargetView BrickAbilityTargetView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityTargetView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomMoraleFlagView BrickKingdomMoraleFlagView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomMoraleFlagView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomMoraleBarView BrickKingdomMoraleBarView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomMoraleBarView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityScoreBonusesView TooltipBrickAbilityScoreBonusesView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickAbilityScoreBonusesView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomRequiredView TooltipBrickKingdomRequiredView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomRequiredView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArmySquadsView TooltipBrickArmySquadsView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArmySquadsView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArmyLeaderView TooltipBrickArmyLeaderView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickArmyLeaderView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomStatView TooltipBrickKingdomStatView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomStatView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomResourcesView TooltipBrickKingdomResourcesView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickKingdomResourcesView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIslandDifficultyView TooltipBrickIslandDifficultyView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIslandDifficultyView */;
    public global::Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIslandRewardView TooltipBrickIslandRewardView /* Kingmaker.UI.MVVM._PCView.Tooltip.Bricks.TooltipBrickIslandRewardView */;
}

}

