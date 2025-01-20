using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.VisualSettings;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Appearance {

public class CharGenAppearancePhaseDetailedConsoleView {
    [SerializeField] public object m_ChooseBodyLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseHairLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseHornsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseWarpaintsLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseTattoosLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChoosePrimaryColorLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ChooseSecondaryColorLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_BodySelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_FaceSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_ScarSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_BodyColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_EyesColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_HairBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_HairBlockPlaceholder /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_HairSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_BeardSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_HairColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_WarpaintBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_WarpaintSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_WarpaintColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ClickablePageNavigation m_WarpaintPaginator /* Kingmaker.UI.Common.ClickablePageNavigation */;
    [SerializeField] public object m_WarpaintPaginatorHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.GameObject m_TattooBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_TatooSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_TatooColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ClickablePageNavigation m_TatooPaginator /* Kingmaker.UI.Common.ClickablePageNavigation */;
    [SerializeField] public object m_TattooPaginatorHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.GameObject m_HornBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView m_HornSelectorPcView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.SlideSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_HornColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_PrimaryOutfitColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView m_SecondaryOutfitColorSelectorView /* Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common.TextureSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController m_CharacterController /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.DollCharacterController */;
    [SerializeField] public global::UnityEngine.RectTransform m_TargetSizeInfoDollTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.VisualSettings.CharacterVisualSettingsConsoleView m_SettingsConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.VisualSettings.CharacterVisualSettingsConsoleView */;
    [SerializeField] public object m_SettingsHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.GameObject m_SettingsContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_DownHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_UpHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

