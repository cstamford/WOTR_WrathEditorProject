using Kingmaker.Kingdom.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Kingdom {

public class RegionObject : MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintRegionReference */;
    public object EventLocations /* Kingmaker.Kingdom.RegionEventLocation[] */;
    public object SettlementLocations /* Kingmaker.Kingdom.SettlementLocation[] */;
    public List<RegionBorder> Borders /* System.Collections.Generic.List<Kingmaker.Kingdom.UI.RegionBorder> */;
    public Texture2D SdfMaskTexture /* UnityEngine.Texture2D */;
    public KingdomRegionTitleView TitleView /* Kingmaker.Kingdom.KingdomRegionTitleView */;
    public Transform Anchor /* UnityEngine.Transform */;
}

}

