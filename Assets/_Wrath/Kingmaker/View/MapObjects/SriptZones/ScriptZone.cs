using Kingmaker.View.MapObjects;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Kingmaker.View.MapObjects.SriptZones {

public class ScriptZone : global::Kingmaker.View.MapObjects.MapObjectView {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintScriptZoneReference */;
    [SerializeField] public global::UnityEngine.Bounds m_Bounds /* UnityEngine.Bounds */;
    [SerializeField] public global::UnityEngine.Bounds[] m_MoreBounds /* UnityEngine.Bounds[] */;
    [SerializeField] public bool m_OnceOnly /* System.Boolean */;
    [SerializeField] public bool m_PlayersOnly /* System.Boolean */;
    [SerializeField] public bool m_StartInactive /* System.Boolean */;
    public global::Kingmaker.View.MapObjects.SriptZones.ScriptZone.UnitEvent OnUnitEntered /* Kingmaker.View.MapObjects.SriptZones.UnitEvent */;
    public global::Kingmaker.View.MapObjects.SriptZones.ScriptZone.UnitEvent OnUnitExited /* Kingmaker.View.MapObjects.SriptZones.UnitEvent */;

    public class UnitEvent : global::UnityEngine.Events.UnityEvent {
    }

}

}

