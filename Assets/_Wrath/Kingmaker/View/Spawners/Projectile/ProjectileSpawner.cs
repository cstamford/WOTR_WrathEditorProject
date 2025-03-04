using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.View.Spawners.Projectile {

public class ProjectileSpawner : global::UnityEngine.MonoBehaviour {
    public object Projectile /* Kingmaker.Blueprints.BlueprintProjectileReference */;
    public bool ActiveInCutscenes /* System.Boolean */;
    public bool ActiveInDialogues /* System.Boolean */;
    public global::UnityEngine.ParticleSystem.MinMaxCurve RateOverTime /* UnityEngine.MinMaxCurve */;
    public float RateOverTimeEvaluationPeriod /* System.Single */;
    public global::Kingmaker.View.Spawners.Projectile.ProjectileSpawner.TimeModeType TimeMode /* Kingmaker.View.Spawners.Projectile.TimeModeType */;
    public bool AdjustByTargetPosition /* System.Boolean */;
    public bool AdjustByTargetsCount /* System.Boolean */;
    public int TargetsCountMaxMultiplier /* System.Int32 */;
    public float InnerRadius /* System.Single */;
    public float OuterRadius /* System.Single */;
    public global::System.Collections.Generic.List<global::UnityEngine.GameObject> SpawnPoints /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public bool DrawGizmos /* System.Boolean */;
    public global::UnityEngine.Color SpawnPointGizmosColor /* UnityEngine.Color */;
    public global::UnityEngine.Color InnerRadiusGizmosColor /* UnityEngine.Color */;
    public global::UnityEngine.Color OuterRadiusGizmosColor /* UnityEngine.Color */;

    public enum TimeModeType {
        GameTime = 0,
        ResetOnTargetsLeft = 1,
    }

}

}

