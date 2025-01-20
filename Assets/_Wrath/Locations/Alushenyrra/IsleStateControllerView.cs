using Kingmaker.View;
using Kingmaker.View.MapObjects.SriptZones;
using System;
using UnityEngine;

namespace Locations.Alushenyrra {

public class IsleStateControllerView {
    [SerializeField] public global::UnityEngine.Animator m_IsleAnimator /* UnityEngine.Animator */;
    [SerializeField] public object m_States /* Locations.Alushenyrra.AnimatorState[] */;
    [SerializeField] public int m_OffsetCount /* System.Int32 */;
    [SerializeField] public bool m_Inversion /* System.Boolean */;
    [SerializeField] public global::Kingmaker.View.MapObjects.SriptZones.ScriptZone m_ControllingZone /* Kingmaker.View.MapObjects.SriptZones.ScriptZone */;
}

}

