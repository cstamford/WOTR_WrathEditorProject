using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal {

public class SkipTimeConsoleView {
    [SerializeField] public object m_CountText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Slider m_HoursSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_CurrentTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_UntilTime /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SkipTimeHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

