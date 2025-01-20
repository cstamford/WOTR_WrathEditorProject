using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CounterWindow {

public class CounterWindowPCView {
    [SerializeField] public object m_ItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_ItemIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Slider m_CountSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_CountText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ButtonLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

