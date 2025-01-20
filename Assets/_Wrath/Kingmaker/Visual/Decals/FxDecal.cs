using System;
using UnityEngine;

namespace Kingmaker.Visual.Decals {

public class FxDecal : global::Kingmaker.Visual.Decals.ScreenSpaceDecal {
    [SerializeField] public object m_ColorRamp /* Kingmaker.Visual.Ramp */;
    public float Delay /* System.Single */;
    public bool IsInvisibleWhileDelay /* System.Boolean */;
    public object Animations /* System.Collections.Generic.List */;
    public bool UseScaleAnimation /* System.Boolean */;
}

}

