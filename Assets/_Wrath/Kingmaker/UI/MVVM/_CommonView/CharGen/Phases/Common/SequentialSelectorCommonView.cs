using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._CommonView.CharGen.Phases.Common {

public class SequentialSelectorCommonView {
    [SerializeField] public object m_CurrentValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object ButtonNext /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object ButtonPrevious /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_Counter /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
}

}

