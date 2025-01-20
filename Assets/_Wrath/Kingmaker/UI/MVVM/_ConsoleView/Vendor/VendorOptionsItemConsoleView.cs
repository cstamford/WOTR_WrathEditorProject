using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Vendor {

public class VendorOptionsItemConsoleView {
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_OptionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_ConsoleHintPrev /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ConsoleHintNext /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

