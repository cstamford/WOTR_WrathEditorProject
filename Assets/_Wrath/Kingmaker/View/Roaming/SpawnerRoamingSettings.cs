using Kingmaker.Visual.Animation.Kingmaker.Actions;
using System;
using UnityEngine;

namespace Kingmaker.View.Roaming {

public class SpawnerRoamingSettings {
    public global::Kingmaker.View.Roaming.SpawnerRoamingSettings.ModeType Mode /* Kingmaker.View.Roaming.ModeType */;
    public object FirstWaypoint /* Kingmaker.Blueprints.EntityReference */;
    public float Radius /* System.Single */;
    public object IdleCutscenes /* Kingmaker.Blueprints.CutsceneReference[] */;
    public float MinIdleTime /* System.Single */;
    public float MaxIdleTime /* System.Single */;
    public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionLocoMotion.WalkSpeedType MovementType /* Kingmaker.Visual.Animation.Kingmaker.Actions.WalkSpeedType */;
    public bool Sleepless /* System.Boolean */;

    public enum ModeType {
        Patrol = 0,
        Radius = 1,
        Cutscene = 2,
    }

}

}

