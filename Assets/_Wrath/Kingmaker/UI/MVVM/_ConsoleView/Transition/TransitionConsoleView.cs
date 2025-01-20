using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Transition {

public class TransitionConsoleView {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionConsoleView.MapPart> m_Parts /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.Transition.MapPart> */;
    [SerializeField] public object m_AlushinyrraWarningLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;

    public class MapPart {
        public object Map /* Kingmaker.Globalmap.Blueprints.BlueprintMultiEntranceMap */;
        public global::UnityEngine.GameObject MapObject /* UnityEngine.GameObject */;
        public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionEntryConsoleView> Entries /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.Transition.TransitionEntryConsoleView> */;
    }

}

}

