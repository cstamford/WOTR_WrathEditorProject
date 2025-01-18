using System;
using System.Collections.Generic;
using UnityEngine;

public class BezierSpline : MonoBehaviour {
    [SerializeField] public List<Vector3> points /* System.Collections.Generic.List<UnityEngine.Vector3> */;
    [SerializeField] public object modes /* System.Collections.Generic.List */;
    [SerializeField] public bool loop /* System.Boolean */;
}

