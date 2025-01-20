using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.AbilityScores;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Alignment;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Appearance;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.FeatureSelector;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Name;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Pregen;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Skills;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Total;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Voice;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class CharGenRoadmapMenuView {
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_RoadMapsScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::UnityEngine.Transform m_NotActiveRoadmapsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Pregen.CharGenPregenPhaseRoadmapPCView m_PregenPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Pregen.CharGenPregenPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenPortraitPhaseRoadmapPCView PortraitPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenPortraitPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race.CharGenRacePhaseRoadmapPCView RacePhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Race.CharGenRacePhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseRoadmapPCView ClassPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Class.CharGenClassPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Appearance.CharGenAppearancePhaseRoadmapPCView AppearancePhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Appearance.CharGenAppearancePhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Appearance.CharGenAppearancePhaseRoadmapPCView AlternativeAppearancePhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Appearance.CharGenAppearancePhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.AbilityScores.CharGenAbilityScoresRoadmapPCView AbilityScoresPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.AbilityScores.CharGenAbilityScoresRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Skills.CharGenSkillsPhaseRoadmapPCView SkillsPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Skills.CharGenSkillsPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Alignment.CharGenAlignmentPhaseRoadmapPCView AlignmentPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Alignment.CharGenAlignmentPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Voice.CharGenVoicePhaseRoadmapPCView VoicePhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Voice.CharGenVoicePhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Name.CharGenNamePhaseRoadmapPCView m_NamePhaseRoadmapView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Name.CharGenNamePhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Total.CharGenTotalPhaseRoadmapPCView TotalPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Total.CharGenTotalPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.FeatureSelector.CharGenFeatureSelectorPhaseRoadmapPCView FeatureSelectorPhaseRoadmapPcViewPrefab /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.FeatureSelector.CharGenFeatureSelectorPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellsPhaseRoadmapPCView SpellsPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells.CharGenSpellsPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic.CharGenMythicPhaseRoadmapPCView MythicPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Mythic.CharGenMythicPhaseRoadmapPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenPortraitPhaseRoadmapPCView MythicPortraitPhaseRoadmapPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Portrait.CharGenPortraitPhaseRoadmapPCView */;
}

}

