using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Common.MessageModal {

public class MarketingMessagePCView {
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SteamButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_SteamButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

