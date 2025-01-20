using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class CharGenPCView {
    [SerializeField] public object PhaseDetailedFactory /* Kingmaker.UI.MVVM._PCView.CharGen.CharGenPhaseDetailedPCViewsFactory */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NextButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NextValidPageButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_BackButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_BackButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_FirstPageButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

