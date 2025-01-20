using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Transition {

public class TransitionPCView {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Transition.TransitionPCView.MapPart> m_Parts /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Transition.MapPart> */;
    [SerializeField] public object m_AlushinyrraWarningLabel /* TMPro.TextMeshProUGUI */;

    public class MapPart {
        public object Map /* Kingmaker.Globalmap.Blueprints.BlueprintMultiEntranceMap */;
        public global::UnityEngine.GameObject MapObject /* UnityEngine.GameObject */;
        public object Close /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
        public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Transition.TransitionEntryPCView> Entries /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Transition.TransitionEntryPCView> */;
    }

}

}

