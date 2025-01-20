using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.VisualSettings;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Appearance {

public class CharGenAppearancePhaseDetailedPCView {
    [SerializeField] public object m_ChooseBodyLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseHairLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseHornsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseWarpaintsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseTattoosLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChoosePrimaryColorLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_BodySelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_FaceSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_ScarSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_BodyColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_EyesColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_HairBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_HairBlockPlaceholder /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_HairSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_BeardSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_HairColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::UnityEngine.GameObject m_WarpaintBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_WarpaintSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_WarpaintColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.ClickablePageNavigation m_WarpaintPaginator /* Kingmaker.UI.Common.ClickablePageNavigation */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_TatooSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_TatooColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.ClickablePageNavigation m_TatooPaginator /* Kingmaker.UI.Common.ClickablePageNavigation */;
    [SerializeField] public global::UnityEngine.GameObject m_HornBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView m_HornSelectorPcView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.SlideSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_HornColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_PrimaryOutfitColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView m_SecondaryOutfitColorSelectorView /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_CharacterController /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeInfoDollTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.VisualSettings.CharacterVisualSettingsPCView m_VisualSettingsView /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Inventory.VisualSettings.CharacterVisualSettingsPCView */;
    [SerializeField] public object m_VisualSettingsButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::UnityEngine.GameObject m_SettingsContainer /* UnityEngine.GameObject */;
}

}

