using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.Rest;
using Kingmaker.UI.MVVM._PCView.Formation;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Formation {

public class FormationConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Formation.FormationSelectorPCView m_FormationSelectorPCView /* Kingmaker.UI.MVVM._PCView.Formation.FormationSelectorPCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_CharacterContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Formation.FormationCharacterConsoleView m_CharacterView /* Kingmaker.UI.MVVM._ConsoleView.Formation.FormationCharacterConsoleView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_Parameters /* Owlcat.Runtime.UI.ConsoleTools.NavigationTool.NavigationParameters */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView m_PreserveFormationMultiButton /* Kingmaker.UI.MVVM._ConsoleView.Rest.FloatButtonConsoleView */;
    [SerializeField] public object m_HoldTheLineText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public object m_LeftHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_RightHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

