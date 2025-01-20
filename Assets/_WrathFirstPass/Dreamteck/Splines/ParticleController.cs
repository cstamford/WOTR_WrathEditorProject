using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class ParticleController : global::Dreamteck.Splines.SplineUser {
    public global::UnityEngine.ParticleSystem _particleSystem /* UnityEngine.ParticleSystem */;
    public bool volumetric /* System.Boolean */;
    public bool emitFromShell /* System.Boolean */;
    public global::UnityEngine.Vector2 scale /* UnityEngine.Vector2 */;
    public global::Dreamteck.Splines.ParticleController.EmitPoint emitPoint /* Dreamteck.Splines.EmitPoint */;
    public global::Dreamteck.Splines.ParticleController.MotionType motionType /* Dreamteck.Splines.MotionType */;
    public global::Dreamteck.Splines.ParticleController.Wrap wrapMode /* Dreamteck.Splines.Wrap */;
    public float minCycles /* System.Single */;
    public float maxCycles /* System.Single */;

    public enum EmitPoint {
        Beginning = 0,
        Ending = 1,
        Random = 2,
        Ordered = 3,
    }

    public enum MotionType {
        None = 0,
        UseParticleSystem = 1,
        FollowForward = 2,
        FollowBackward = 3,
        ByNormal = 4,
        ByNormalRandomized = 5,
    }

    public enum Wrap {
        Default = 0,
        Loop = 1,
    }

}

}

