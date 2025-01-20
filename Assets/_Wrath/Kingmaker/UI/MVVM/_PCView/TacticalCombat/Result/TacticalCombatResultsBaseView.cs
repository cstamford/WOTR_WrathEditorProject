using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.TacticalCombat.Result {

public class TacticalCombatResultsBaseView {
    [SerializeField] public global::UnityEngine.UI.Image m_VictoryPaperImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_DefeatPaperImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_VictoryStateObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_DefeatStateObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_OurGeneralBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_OurVictoryFlagObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_OurDefeatFlagObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_OurGeneralName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_OurGeneralPortrait /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Slider m_OurGeneralResourceSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_OurGeneralResourceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_OurGeneralLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_OurGeneralExperienceSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_ExperienceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ExperienceGainedText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_OurGeneralPlaceholderImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_EnemyGeneralBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_EnemyVictoryFlagObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_EnemyDefeatFlagObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_EnemyGeneralPortraitImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_EnemyGeneralName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_EnemyGeneralLevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_EnemyGeneralResourceSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_EnemyGeneralResourceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_EnemyGeneralStateText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_EnemyGeneralPlaceholderImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultUnitPCView m_UnitView /* Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultUnitPCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_OurLossesFirstRowRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_OurLossesSecondRowRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_EnemyLossesFirstRowRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_EnemyLossesSecondRowRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_HospitalRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject m_DefeatBottomBlockObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_RetreatText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_VictoryBottomBlockObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_BottomBlockResourcesObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_GemsObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_GemsText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_ResourcesObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_ResourcesText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_RunesObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_RunesText /* TMPro.TextMeshProUGUI */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultUnitPCView> m_UnitViews /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.TacticalCombat.Result.TacticalCombatResultUnitPCView> */;
}

}

