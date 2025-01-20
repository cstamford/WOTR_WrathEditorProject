using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Common.MessageModal {

public class SkipTimePCView {
    [SerializeField] public object m_CountText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_HoursSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public object m_SkipTimeButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_CurrentTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_UntilTime /* TMPro.TextMeshProUGUI */;
}

}

