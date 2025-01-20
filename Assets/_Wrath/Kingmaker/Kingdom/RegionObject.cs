using Kingmaker.Kingdom.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Kingdom {

public class RegionObject : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintRegionReference */;
    public object EventLocations /* Kingmaker.Kingdom.RegionEventLocation[] */;
    public object SettlementLocations /* Kingmaker.Kingdom.SettlementLocation[] */;
    public global::System.Collections.Generic.List<global::Kingmaker.Kingdom.UI.RegionBorder> Borders /* System.Collections.Generic.List<Kingmaker.Kingdom.UI.RegionBorder> */;
    public global::UnityEngine.Texture2D SdfMaskTexture /* UnityEngine.Texture2D */;
    public global::Kingmaker.Kingdom.KingdomRegionTitleView TitleView /* Kingmaker.Kingdom.KingdomRegionTitleView */;
    public global::UnityEngine.Transform Anchor /* UnityEngine.Transform */;
}

}

