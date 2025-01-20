using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class Node : global::UnityEngine.MonoBehaviour {
    public global::Dreamteck.Splines.Node.Type type /* Dreamteck.Splines.Type */;
    [SerializeField] public object connections /* Dreamteck.Splines.Connection[] */;
    [SerializeField] public bool _transformSize /* System.Boolean */;
    [SerializeField] public bool _transformNormals /* System.Boolean */;
    [SerializeField] public bool _transformTangents /* System.Boolean */;

    public class Connection {
        public bool invertTangents /* System.Boolean */;
        [SerializeField] public int _pointIndex /* System.Int32 */;
        [SerializeField] public global::Dreamteck.Splines.SplineComputer _computer /* Dreamteck.Splines.SplineComputer */;
        [SerializeField] public object point /* Dreamteck.Splines.SplinePoint */;
    }

    public enum Type {
        Smooth = 0,
        Free = 1,
    }

}

}

