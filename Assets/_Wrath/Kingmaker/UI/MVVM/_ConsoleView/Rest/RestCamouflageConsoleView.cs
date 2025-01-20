using Kingmaker.UI.MVVM._PCView.Rest;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Rest {

public class RestCamouflageConsoleView : global::Kingmaker.UI.MVVM._PCView.Rest.RestCamouflageBaseView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView m_PrimaryShiftView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView m_SecondaryShiftView /* Kingmaker.UI.MVVM._ConsoleView.Rest.RestShiftConsoleView */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
}

}

