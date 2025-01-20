using Kingmaker.Visual.Kingdom;
using System;
using UnityEngine;

namespace Kingmaker.Kingdom {

public class KingdomRegionGlowController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.Visual.Kingdom.BorderGlowHighlighter m_BorderGlowHighlighter /* Kingmaker.Visual.Kingdom.BorderGlowHighlighter */;
    [SerializeField] public global::UnityEngine.Transform m_BordersContainer /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.Kingdom.RegionObject m_TerraIncognita /* Kingmaker.Kingdom.RegionObject */;
    public global::UnityEngine.Color ClaimColor /* UnityEngine.Color */;
    public global::UnityEngine.Color UnclaimColor /* UnityEngine.Color */;
    public float BaseWidth /* System.Single */;
    public float WidthMultiplier /* System.Single */;
    public float Time /* System.Single */;
    public global::Kingmaker.Kingdom.KingdomRegionGlowController.AnimTimes Line00 /* Kingmaker.Kingdom.AnimTimes */;
    public global::Kingmaker.Kingdom.KingdomRegionGlowController.AnimTimes Line0102 /* Kingmaker.Kingdom.AnimTimes */;
    public global::Kingmaker.Kingdom.KingdomRegionGlowController.AnimTimes Line03 /* Kingmaker.Kingdom.AnimTimes */;

    public class AnimTimes {
        public float StartDuration /* System.Single */;
        public float StartDelay /* System.Single */;
        public float EndDuration /* System.Single */;
        public float EndDelay /* System.Single */;
    }

}

}

