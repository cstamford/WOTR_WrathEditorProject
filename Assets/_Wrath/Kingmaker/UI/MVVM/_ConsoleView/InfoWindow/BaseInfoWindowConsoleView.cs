using Kingmaker.UI.MVVM._PCView.InfoWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.InfoWindow {

public class BaseInfoWindowConsoleView : global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoWindowView {
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    public object IsWindowOpen /* UniRx.BoolReactiveProperty */;
}

}

