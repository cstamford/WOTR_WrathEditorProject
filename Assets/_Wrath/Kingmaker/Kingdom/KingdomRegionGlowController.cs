using Kingmaker.Visual.Kingdom;
using System;
using UnityEngine;

namespace Kingmaker.Kingdom {

public class KingdomRegionGlowController : MonoBehaviour {
    [SerializeField] public BorderGlowHighlighter m_BorderGlowHighlighter /* Kingmaker.Visual.Kingdom.BorderGlowHighlighter */;
    [SerializeField] public Transform m_BordersContainer /* UnityEngine.Transform */;
    [SerializeField] public RegionObject m_TerraIncognita /* Kingmaker.Kingdom.RegionObject */;
    public Color ClaimColor /* UnityEngine.Color */;
    public Color UnclaimColor /* UnityEngine.Color */;
    public float BaseWidth /* System.Single */;
    public float WidthMultiplier /* System.Single */;
    public float Time /* System.Single */;
    public KingdomRegionGlowController.AnimTimes Line00 /* Kingmaker.Kingdom.AnimTimes */;
    public KingdomRegionGlowController.AnimTimes Line0102 /* Kingmaker.Kingdom.AnimTimes */;
    public KingdomRegionGlowController.AnimTimes Line03 /* Kingmaker.Kingdom.AnimTimes */;

    public class AnimTimes {
        public float StartDuration /* System.Single */;
        public float StartDelay /* System.Single */;
        public float EndDuration /* System.Single */;
        public float EndDelay /* System.Single */;
    }

}

}

