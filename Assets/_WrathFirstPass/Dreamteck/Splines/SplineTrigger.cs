using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineTrigger : global::UnityEngine.ScriptableObject {
    [SerializeField] public global::Dreamteck.Splines.SplineTrigger.Type type /* Dreamteck.Splines.Type */;
    public double position /* System.Double */;
    [SerializeField] public bool enabled /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Color color /* UnityEngine.Color */;
    [SerializeField] public object actions /* Dreamteck.Splines.SplineAction[] */;
    public global::UnityEngine.GameObject[] gameObjects /* UnityEngine.GameObject[] */;

    public enum Type {
        Double = 0,
        Forward = 1,
        Backward = 2,
    }

}

}

