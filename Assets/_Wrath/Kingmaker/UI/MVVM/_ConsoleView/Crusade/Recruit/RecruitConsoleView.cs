using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo;
using Kingmaker.UI.MVVM._PCView.Crusade.Recruit;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Crusade.Recruit {

public class RecruitConsoleView {
    [SerializeField] public object m_BuyResourceButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MercRerollConsoleButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MercUpConsoleButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MercDownConsoleButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_CreateArmyHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_PrevMergeArmy /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_NextMergeArmy /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmySquadSelectorConsoleView m_SquadSelector /* Kingmaker.UI.MVVM._ConsoleView.Crusade.ArmyInfo.ArmySquadSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ShopScrollView /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_MercScrollView /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

