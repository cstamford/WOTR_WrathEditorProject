using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._PCView.Crusade.Recruit;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomStatsContent : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_MoraleCountLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.MonoBehaviour m_MoraleTooltip /* UnityEngine.MonoBehaviour */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomStatContentStats m_Stats /* Kingmaker.UI.Kingdom.KingdomStatContentStats */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.Kingdom.KingdomStatsContent.StatContentResources> m_Resources /* System.Collections.Generic.List<Kingmaker.UI.Kingdom.StatContentResources> */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesPCView m_BuyResourcesPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesPCView */;
    [SerializeField] public object m_BuyResourceButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;

    public class StatContentResources {
        public global::UnityEngine.UI.Image Icon /* UnityEngine.UI.Image */;
        public object Title /* TMPro.TextMeshProUGUI */;
        public object Count /* TMPro.TextMeshProUGUI */;
        public global::UnityEngine.MonoBehaviour Tooltip /* UnityEngine.MonoBehaviour */;
    }

}

}

