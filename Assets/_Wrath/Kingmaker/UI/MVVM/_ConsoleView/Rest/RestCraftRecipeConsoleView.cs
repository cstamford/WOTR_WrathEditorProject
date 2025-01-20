using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.Rest;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Rest {

public class RestCraftRecipeConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestCraftRadioSelectorConsoleView m_RadioSelector /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestCraftRadioSelectorConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRectExtended /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestRecipeIngredientItemConsoleView> m_IngredientItemViews /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.Rest.RestRecipeIngredientItemConsoleView> */;
    [SerializeField] public object m_Parameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_PotionCraftConfirmButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_PotionCraftConfirmHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ListSwitchHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_InformationSwitchHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_InformationHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_FirstGlossaryFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_SecondGlossaryFocus /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

