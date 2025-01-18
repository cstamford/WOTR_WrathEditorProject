using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomEventHand : MonoBehaviour {
    [SerializeField] public KingdomEventHandCartController m_Cart /* Kingmaker.UI.Kingdom.KingdomEventHandCartController */;
    public float Radius /* System.Single */;
    public float OffsetY /* System.Single */;
    public float HoverOffset /* System.Single */;
    public float hoverDeltaAngle /* System.Single */;
    public bool NaviChanged /* System.Boolean */;
}

}

