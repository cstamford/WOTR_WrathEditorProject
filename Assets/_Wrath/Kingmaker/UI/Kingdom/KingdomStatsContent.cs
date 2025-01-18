using Kingmaker.UI.Common.Animations;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomStatsContent : MonoBehaviour {
    [SerializeField] public FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_MoraleCountLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public MonoBehaviour m_MoraleTooltip /* UnityEngine.MonoBehaviour */;
    [SerializeField] public KingdomStatContentStats m_Stats /* Kingmaker.UI.Kingdom.KingdomStatContentStats */;
    [SerializeField] public List<KingdomStatsContent.StatContentResources> m_Resources /* System.Collections.Generic.List<Kingmaker.UI.Kingdom.StatContentResources> */;
    [SerializeField] public object m_BuyResourcesPCView /* Kingmaker.UI.MVVM._PCView.Crusade.Recruit.RecruitBuyResourcesPCView */;
    [SerializeField] public object m_BuyResourceButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;

    public class StatContentResources {
        public Image Icon /* UnityEngine.UI.Image */;
        public object Title /* TMPro.TextMeshProUGUI */;
        public object Count /* TMPro.TextMeshProUGUI */;
        public MonoBehaviour Tooltip /* UnityEngine.MonoBehaviour */;
    }

}

}

