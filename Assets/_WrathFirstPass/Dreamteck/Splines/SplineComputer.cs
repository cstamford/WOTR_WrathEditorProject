using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineComputer : MonoBehaviour {
    [SerializeField] public object spline /* Dreamteck.Splines.Spline */;
    [SerializeField] public SplineComputer.Morph _morph /* Dreamteck.Splines.Morph */;
    [SerializeField] public SplineComputer.Space _space /* Dreamteck.Splines.Space */;
    [SerializeField] public object subscribers /* Dreamteck.Splines.SplineUser[] */;
    [SerializeField] public object _nodeLinks /* Dreamteck.Splines.NodeLink[] */;

    public class NodeLink {
        public object node /* Dreamteck.Splines.Node */;
        public int pointIndex /* System.Int32 */;
    }

    public enum Space {
        World = 0,
        Local = 1,
    }

    public class Morph {
        [SerializeField] public object computer /* Dreamteck.Splines.SplineComputer */;
        [SerializeField] public object morphStates /* Dreamteck.Splines.SplineMorphState[] */;
        [SerializeField] public bool initialized /* System.Boolean */;

        public class SplineMorphState {
            public object points /* Dreamteck.Splines.SplinePoint[] */;
            public float percent /* System.Single */;
            public string name /* System.String */;
        }

    }

}

}

