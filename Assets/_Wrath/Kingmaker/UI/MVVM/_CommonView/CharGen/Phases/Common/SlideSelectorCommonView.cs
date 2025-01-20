using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._CommonView.CharGen.Phases.Common {

public class SlideSelectorCommonView {
    [SerializeField] public global::UnityEngine.UI.Slider m_Slider /* UnityEngine.UI.Slider */;
    [SerializeField] public bool m_CalculateHandleSize /* System.Boolean */;
    [SerializeField] public global::UnityEngine.RectTransform m_SliderRect /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_SliderSlideArea /* UnityEngine.RectTransform */;
    [SerializeField] public object m_ButtonNext /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_ButtonPrevious /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_Value /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Counter /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
}

}

