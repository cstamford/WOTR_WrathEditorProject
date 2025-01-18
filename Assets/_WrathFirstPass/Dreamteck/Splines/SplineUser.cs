using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineUser : MonoBehaviour {
    public object _address /* Dreamteck.Splines.SplineAddress */;
    [SerializeField] public object subscribers /* Dreamteck.Splines.SplineUser[] */;
    public SplineUser.UpdateMethod updateMethod /* Dreamteck.Splines.UpdateMethod */;
    [SerializeField] public SplineUser _user /* Dreamteck.Splines.SplineUser */;
    [SerializeField] public double _resolution /* System.Double */;
    [SerializeField] public double _clipTo /* System.Double */;
    [SerializeField] public double _clipFrom /* System.Double */;
    [SerializeField] public bool _autoUpdate /* System.Boolean */;
    [SerializeField] public bool _loopSamples /* System.Boolean */;
    [SerializeField] public bool _uniformSample /* System.Boolean */;
    [SerializeField] public bool _uniformPreserveClipRange /* System.Boolean */;
    [SerializeField] public object _samples /* Dreamteck.Splines.SplineResult[] */;
    [SerializeField] public object _clippedSamples /* Dreamteck.Splines.SplineResult[] */;
    [SerializeField] public float animClipFrom /* System.Single */;
    [SerializeField] public float animClipTo /* System.Single */;
    [SerializeField] public double animResolution /* System.Double */;
    [SerializeField] public bool sampleUser /* System.Boolean */;
    public bool multithreaded /* System.Boolean */;
    public bool buildOnAwake /* System.Boolean */;
    public bool buildOnEnable /* System.Boolean */;

    public enum UpdateMethod {
        Update = 0,
        FixedUpdate = 1,
        LateUpdate = 2,
    }

}

}

