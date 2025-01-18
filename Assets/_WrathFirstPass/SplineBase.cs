using System;
using System.Collections.Generic;
using UnityEngine;

public class SplineBase : MonoBehaviour {
    [SerializeField] public List<Vector3> _nodes /* System.Collections.Generic.List<UnityEngine.Vector3> */;
    [SerializeField] public bool _isClosed /* System.Boolean */;
    public Color Color /* UnityEngine.Color */;
    public bool ShowVelocities /* System.Boolean */;
}

