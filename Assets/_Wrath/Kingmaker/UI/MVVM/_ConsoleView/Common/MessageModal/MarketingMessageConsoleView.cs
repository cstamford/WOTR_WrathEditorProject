using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal {

public class MarketingMessageConsoleView {
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SteamButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SteamButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_SteamButtonHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

