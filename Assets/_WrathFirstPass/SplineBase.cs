using System;
using System.Collections.Generic;
using UnityEngine;

public class SplineBase : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Vector3> _nodes /* System.Collections.Generic.List<UnityEngine.Vector3> */;
    [SerializeField] public bool _isClosed /* System.Boolean */;
    public global::UnityEngine.Color Color /* UnityEngine.Color */;
    public bool ShowVelocities /* System.Boolean */;
}

