using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineFollower : global::Dreamteck.Splines.SplineTracer {
    public global::Dreamteck.Splines.SplineFollower.Wrap wrapMode /* Dreamteck.Splines.Wrap */;
    public global::Dreamteck.Splines.SplineFollower.FollowMode followMode /* Dreamteck.Splines.FollowMode */;
    public bool autoStartPosition /* System.Boolean */;
    public bool autoFollow /* System.Boolean */;
    [SerializeField] public float _followSpeed /* System.Single */;
    [SerializeField] public float _followDuration /* System.Single */;

    public enum FollowMode {
        Uniform = 0,
        Time = 1,
    }

    public enum Wrap {
        Default = 0,
        Loop = 1,
        PingPong = 2,
    }

}

}

