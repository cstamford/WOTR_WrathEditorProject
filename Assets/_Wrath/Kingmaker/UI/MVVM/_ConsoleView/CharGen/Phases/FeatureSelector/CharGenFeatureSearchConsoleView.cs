using Kingmaker.UI.MVVM._ConsoleView.Common.InputField;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.FeatureSelector {

public class CharGenFeatureSearchConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_ConsoleInputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public object m_FilterButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    public object SearchRequest /* UniRx.StringReactiveProperty */;
}

}

