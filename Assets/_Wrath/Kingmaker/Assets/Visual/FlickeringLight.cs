using System;
using UnityEngine;

namespace Kingmaker.Assets.Visual {

public class FlickeringLight : global::UnityEngine.MonoBehaviour {
    public float IterationInterval /* System.Single */;
    public global::Kingmaker.Assets.Visual.FlickeringLight.FlickerinLightStyles FlickeringLightStyle /* Kingmaker.Assets.Visual.FlickerinLightStyles */;
    public global::Kingmaker.Assets.Visual.FlickeringLight.CampfireMethods CampfireMethod /* Kingmaker.Assets.Visual.CampfireMethods */;
    public global::Kingmaker.Assets.Visual.FlickeringLight.CampfireIntesityStyles CampfireIntesityStyle /* Kingmaker.Assets.Visual.CampfireIntesityStyles */;
    public global::Kingmaker.Assets.Visual.FlickeringLight.CampfireRangeStyles CampfireRangeStyle /* Kingmaker.Assets.Visual.CampfireRangeStyles */;
    public float CampfireIntensityBaseValue /* System.Single */;
    public float CampfireIntensityFlickerValue /* System.Single */;
    public float CampfireRangeBaseValue /* System.Single */;
    public float CampfireRangeFlickerValue /* System.Single */;
    public float CampfireSineCycleIntensitySpeed /* System.Single */;
    public float CampfireSineCycleRangeSpeed /* System.Single */;
    public float FluorescentFlickerMin /* System.Single */;
    public float FluorescentFlickerMax /* System.Single */;
    public float FluorescentFlicerPercent /* System.Single */;

    public enum FlickerinLightStyles {
        CampFire = 0,
        Fluorescent = 1,
    }

    public enum CampfireMethods {
        Intensity = 0,
        Range = 1,
        Both = 2,
    }

    public enum CampfireIntesityStyles {
        Sine = 0,
        Random = 1,
    }

    public enum CampfireRangeStyles {
        Sine = 0,
        Random = 1,
    }

}

}

