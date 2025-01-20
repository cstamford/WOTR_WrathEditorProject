using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.FeatureSelector {

public class CharGenFeatureSearchPCView {
    [SerializeField] public object m_InputField /* TMPro.TMP_InputField */;
    [SerializeField] public object m_EnterPlaceholder /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Placeholder /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_InputButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    public object SearchRequest /* UniRx.StringReactiveProperty */;
    [SerializeField] public object m_DropdownButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object Dropdown /* TMPro.TMP_Dropdown */;
}

}

